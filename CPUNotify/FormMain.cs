using Ambiesoft;
using NDesk.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CPUNotify
{
    public partial class FormMain : Form
    {
        static readonly string SECTION_OPTION = "Option";
        static readonly string KEY_APP = "App";
        static readonly string KEY_ARG = "Arg";
        static readonly string KEY_CHECKDURATION = "CheckDuration";
        static readonly string KEY_MIN_CPUUSAGE = "MinCpuUsage";
        static readonly string KEY_MAX_CPUUSAGE = "MaxCpuUsage";
        static readonly string KEY_IS_AVERAGE = "IsAverage";

        static readonly string SECTION_LOCATION = "Location";
        private readonly bool _start;
        float? _minCPUUsage;
        float? _maxCPUUsage;
        int? _checkDuration;
        bool _isAverage;

        int _totalHits = 0;
        int _timerInterval = 1 * 1000;
        PerformanceCounter _cpuCounter = new PerformanceCounter();
        public FormMain(string[] args)
        {
            InitializeComponent();

            this.Text = Application.ProductName;

            // read ini
            HashIni ini = Profile.ReadAll(IniPath);
            string svalue;
            Profile.GetString(SECTION_OPTION, KEY_APP, string.Empty, out svalue, ini);
            txtApp.Text = svalue;
            Profile.GetString(SECTION_OPTION, KEY_ARG, string.Empty, out svalue, ini);
            txtArg.Text = svalue;

            AmbLib.LoadFormXYWH(this, SECTION_LOCATION, ini);

            int intval;
            if (Profile.GetInt(SECTION_OPTION, KEY_CHECKDURATION, 0, out intval, ini))
                _checkDuration = intval;
            float fval;
            if (Profile.GetFloat(SECTION_OPTION, KEY_MIN_CPUUSAGE, 0, out fval, ini))
                _minCPUUsage = fval;
            if (Profile.GetFloat(SECTION_OPTION, KEY_MAX_CPUUSAGE, 0, out fval, ini))
                _maxCPUUsage = fval;
            
            bool bval;
            if (Profile.GetBool(SECTION_OPTION, KEY_IS_AVERAGE, false, out bval, ini))
                _isAverage = bval;

            try
            {
                bool start = false;
                var p = new OptionSet();
                p.Add("v|version", "Show Version", dummy =>
                {
                    MessageBox.Show("ver");
                    Environment.Exit(0);
                });
                p.Add("max=", "Max cpu usage", max =>
                {
                    _maxCPUUsage = float.Parse(max);
                });
                p.Add("min=", "Min cpu usage", max =>
                {
                    _minCPUUsage = float.Parse(max);
                });
                p.Add("d=|duration=", "Duration of checking", duration =>
                {
                    _checkDuration = int.Parse(duration);
                });
                p.Add("a|average", "Use average", dummy =>
                {
                    _isAverage = true;
                });
                p.Add("h|H|help|?", "Show Help", dummy =>
                {
                    var stream = new MemoryStream();
                    var to = new StreamWriter(stream);
                    p.WriteOptionDescriptions(to);
                    to.Flush();
                    stream.Position = 0;
                    var reader = new StreamReader(stream);
                    string message = reader.ReadToEnd();

                    MessageBox.Show(message,
                        Application.ProductName + " v" + AmbLib.getAssemblyVersion(Assembly.GetExecutingAssembly(),3),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Environment.Exit(0);
                });
                p.Add("start", "Start without showing the dialog", dummy =>
                {
                    start = true;
                });

                List<string> mainArgs = p.Parse(args);
                _start = start;
                if (mainArgs.Count != 0)
                {
                    FatalExit("Uknown Option:" + string.Join(" ", mainArgs.ToArray()));
                }
            }
            catch (Exception ex)
            {
                FatalExit(ex.Message);
            }
        }

        void OnAfterLoad(object sender, EventArgs e)
        {
            if (!_start)
            {
                using (var form = new FormNewInput())
                {
                    form.MinCpuUsage = _minCPUUsage ?? 0;
                    form.MaxCpuUsage = _maxCPUUsage ?? 100;
                    form.Duration = _checkDuration ?? 0;
                    form.IsAverage = _isAverage;
                    
                    if (DialogResult.OK != form.ShowDialog())
                        Environment.Exit(0);
                    _minCPUUsage = form.MinCpuUsage;
                    _maxCPUUsage = form.MaxCpuUsage;
                    _checkDuration = form.Duration;
                    _isAverage = form.IsAverage;

                    HashIni ini = Profile.ReadAll(IniPath);
                    Profile.WriteInt(SECTION_OPTION, KEY_CHECKDURATION, form.Duration, ini);
                    Profile.WriteFloat(SECTION_OPTION, KEY_MIN_CPUUSAGE, form.MinCpuUsage, ini);
                    Profile.WriteFloat(SECTION_OPTION, KEY_MAX_CPUUSAGE, form.MaxCpuUsage, ini);
                    Profile.WriteBool(SECTION_OPTION, KEY_IS_AVERAGE, form.IsAverage, ini);

                    if (!Profile.WriteAll(ini, IniPath))
                    {
                        MessageBox.Show("failed to save ini");
                    }
                }
            }

            if (_minCPUUsage == null)
                _minCPUUsage = 0;
            if (_maxCPUUsage == null)
                _maxCPUUsage = 100;

           txtRangeAndDuration.Text = string.Format("{0} <= [Usage] <= {1} | {2} seconds",
                _minCPUUsage, _maxCPUUsage, _checkDuration);

            _cpuCounter.CategoryName = "Processor";
            _cpuCounter.CounterName = "% Processor Time";
            _cpuCounter.InstanceName = "_Total";
            _cpuCounter.NextValue();

            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new EventHandler(OnAfterLoad));
        }

        string IniPath
        {
            get
            {
                return Path.Combine(
                    Path.GetDirectoryName(Application.ExecutablePath),
                    Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini");
            }
        }
        void FatalExit(string message, bool bExit)
        {
            CppUtils.Alert(message);
            if(bExit)
                Environment.Exit(1);
        }
        void FatalExit(string message)
        {
            FatalExit(message, true);
        }
        // https://stackoverflow.com/a/6168408
        public float getCPUCounter()
        {
            // now matches task manager reading
            return _cpuCounter.NextValue();
        }

        Queue<float> usageHistory = new Queue<float>();
        float calculateAverage()
        {
            if (usageHistory.Count == 0)
                return 0;
            float ret = 0;
            foreach (float f in usageHistory)
                ret += f;
            return ret / usageHistory.Count;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (IsPaused())
                return;

            float cpuPercent = getCPUCounter();

            if (_isAverage)
            {
                if (usageHistory.Count >= _checkDuration)
                    usageHistory.Dequeue();
                usageHistory.Enqueue(cpuPercent);

                float calcedAverage = calculateAverage();
                txtCpuUsage.Text = string.Format("'{0}%' in average for last {1} secs, current usage '{2}%'",
                    calcedAverage, usageHistory.Count, cpuPercent);

                if(usageHistory.Count >= _checkDuration)
                {
                    if(_minCPUUsage <= calcedAverage && calcedAverage <= _maxCPUUsage)
                    {
                        LaunchApp(true);
                    }
                }
            }
            else
            {
                txtCpuUsage.Text = string.Format("{0} Hits in consecutive {1} secs, current cpu '{2}%'",
                    _totalHits, _checkDuration, cpuPercent);

                if (_minCPUUsage <= cpuPercent && cpuPercent <= _maxCPUUsage)
                {
                    _totalHits++;
                    if (_totalHits == _checkDuration)
                    {
                        LaunchApp(true);
                    }
                }
                else
                {
                    _totalHits = 0;
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string iniPath = IniPath;
            HashIni ini = Profile.ReadAll(iniPath);
            Profile.WriteString(SECTION_OPTION, KEY_APP, txtApp.Text, ini);
            Profile.WriteString(SECTION_OPTION, KEY_ARG, txtArg.Text, ini);

            AmbLib.SaveFormXYWH(this, SECTION_LOCATION, ini);

            if (!Profile.WriteAll(ini,iniPath))
            {
                MessageBox.Show("ini save failed");
            }
        }

        private void btnBrowseApp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "title";
                dlg.DefaultExt = "exe";
                StringBuilder sbFilter = new StringBuilder();
                sbFilter.Append("Application");
                sbFilter.Append(" ");
                sbFilter.Append("(*");
                sbFilter.Append(".exe");
                sbFilter.Append(")|*");
                sbFilter.Append(".exe");
                sbFilter.Append("|");
                sbFilter.Append("All Files (*.*)|*.*");

                dlg.Filter = sbFilter.ToString();
                if (DialogResult.OK != dlg.ShowDialog())
                    return;

                txtApp.Text = dlg.FileName;
            }
        }

        private void btnBrowseArg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "title";
                if (DialogResult.OK != dlg.ShowDialog())
                    return;

                txtArg.Text = dlg.FileName;
            }
        }

        void LaunchApp(bool bExit)
        {
            if (bExit)
            {
                timerMain.Enabled = false;
            }
             
            try
            {
                if (!string.IsNullOrEmpty(txtApp.Text) && !string.IsNullOrEmpty(txtArg.Text))
                    Process.Start(txtApp.Text, txtArg.Text);
                else
                    Process.Start(!string.IsNullOrEmpty(txtApp.Text) ?
                        txtApp.Text : txtArg.Text);
            }
            catch (Exception ex)
            {
                FatalExit(ex.Message, bExit);
            }
            if (bExit)
            {
                Close();
            }
        }
        private void btnTestLaunch_Click(object sender, EventArgs e)
        {
            LaunchApp(false);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            TogglePause();
        }
        bool IsPaused()
        {
            return btnPause.Tag is bool ? ((bool)(btnPause.Tag)) : false;
        }
        void TogglePause()
        {
            if (IsPaused())
            {
                btnPause.Tag = false;
                btnPause.Text = " | | ";
            }
            else
            {
                btnPause.Tag = true;
                btnPause.Text = " > ";
            }
        }
    }
}
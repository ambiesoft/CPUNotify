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
using System.Text;
using System.Windows.Forms;

namespace CPUNotify
{
    public partial class FormMain : Form
    {
        static readonly string SECTION_OPTION = "Option";
        static readonly string KEY_APP = "App";
        static readonly string KEY_ARG = "Arg";

        float? _minCPUUsage;
        float? _maxCPUUsage;
        int? _checkDuration;

        int _totalHits = 0;
        int _timerInterval = 1 * 1000;
        PerformanceCounter _cpuCounter = new PerformanceCounter();
        public FormMain(string[] args)
        {
            InitializeComponent();

            // read ini
            HashIni ini = Profile.ReadAll(IniPath);
            string svalue;
            Profile.GetString(SECTION_OPTION, KEY_APP, string.Empty, out svalue, ini);
            txtApp.Text = svalue;
            Profile.GetString(SECTION_OPTION, KEY_ARG, string.Empty, out svalue, ini);
            txtArg.Text = svalue;

            try
            {
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
                p.Add("h|H|help|?", "Show Help", dummy =>
                {
                    p.WriteOptionDescriptions(Console.Out);
                });

                List<string> mainArgs = p.Parse(args);
                if (mainArgs.Count != 0)
                {
                    FatalExit("Uknown Option:" + string.Join(" ", mainArgs.ToArray()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        void OnAfterLoad(object sender, EventArgs e)
        {            // check options
            if ((_minCPUUsage == null && _maxCPUUsage == null) ||
                _checkDuration == null)
            {
                using (var form = new FormNewInput())
                {
                    form.MinCpuUsage = _minCPUUsage ?? 0;
                    form.MaxCpuUsage = _maxCPUUsage ?? 100;
                    form.Duration = _checkDuration ?? 0;
                    if (DialogResult.OK != form.ShowDialog())
                        Environment.Exit(0);
                    _minCPUUsage = form.MinCpuUsage;
                    _maxCPUUsage = form.MaxCpuUsage;
                    _checkDuration = form.Duration;
                }
            }
            if (_minCPUUsage == null)
                _minCPUUsage = 0;
            if (_maxCPUUsage == null)
                _maxCPUUsage = 100;


            txtCheckRange.Text = string.Format("{0} <= [Usage] <= {1}",
                _minCPUUsage, _maxCPUUsage);

            _cpuCounter.CategoryName = "Processor";
            _cpuCounter.CounterName = "% Processor Time";
            _cpuCounter.InstanceName = "_Total";
            // will always start at 0
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
            MessageBox.Show(message);
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

        private void timerMain_Tick(object sender, EventArgs e)
        {
            float cpuPercent = getCPUCounter();

            txtCpuUsage.Text = string.Format("{0} Hits in consecutive {1} secs, current cpu '{2}%'",
                _totalHits, _checkDuration, cpuPercent);

            if (_minCPUUsage <= cpuPercent && cpuPercent <= _maxCPUUsage)
            {
                _totalHits++;
                if (_totalHits == _checkDuration)
                {
                    LaunchApp(true);
                    Close();
                }
            }
            else
            {
                _totalHits = 0;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string iniPath = IniPath;
            HashIni ini = Profile.ReadAll(iniPath);
            Profile.WriteString(SECTION_OPTION, KEY_APP, txtApp.Text, ini);
            Profile.WriteString(SECTION_OPTION, KEY_ARG, txtArg.Text, ini);
            if(!Profile.WriteAll(ini,iniPath))
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
        }
        private void btnTestLaunch_Click(object sender, EventArgs e)
        {
            LaunchApp(false);
        }

     
    }
}
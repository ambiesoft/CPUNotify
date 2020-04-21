using NDesk.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPUNotify
{
    public partial class FormMain : Form
    {
        
        float? _minCPUUsage;
        float? _maxCPUUsage;
        int? _checkDuration;

        int _totalHits = 0;
        int _timerInterval = 10 * 1000;
        PerformanceCounter _cpuCounter = new PerformanceCounter();
        public FormMain(string[] args)
        {
            InitializeComponent();

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

            // check options
            if (_minCPUUsage == null && _maxCPUUsage == null)
            {
                FatalExit("Min and max are both null");
            }
            if (_minCPUUsage == null)
                _minCPUUsage = 100;
            if (_maxCPUUsage == null)
                _maxCPUUsage = 0;

            if (_checkDuration == null)
                FatalExit("Duration is empty");

            _cpuCounter.CategoryName = "Processor";
            _cpuCounter.CounterName = "% Processor Time";
            _cpuCounter.InstanceName = "_Total";
            // will always start at 0
            _cpuCounter.NextValue();

            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;

          
        }

        void FatalExit(string message)
        {
            MessageBox.Show(message);
            Environment.Exit(1);
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

            txtCpuUsage.Text = string.Format("{0}Hits in {1}, current cpu '{2}%'",
                _totalHits, _checkDuration, cpuPercent);

            if (_minCPUUsage <= cpuPercent && cpuPercent <= _maxCPUUsage)
            {
                _totalHits++;
                if (_totalHits == _checkDuration)
                {
                    try
                    {
                        Process.Start(txtApp.Text, txtArg.Text);
                    }
                    catch(Exception ex)
                    {
                        FatalExit(ex.Message);
                    }

                    Close();
                }
            }
            else
            {
                _totalHits = 0;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPUNotify
{
    public partial class FormNewInput : Form
    {
        public FormNewInput()
        {
            InitializeComponent();
            UpdateDialog();
        }

        internal float MinCpuUsage
        {
            get { return Decimal.ToInt32(udMin.Value); }
            set { udMin.Value = (decimal)value; }
            
        }
        internal float MaxCpuUsage
        {
            get { return Decimal.ToInt32(udMax.Value); }
            set { udMax.Value = (decimal)value; }
        }
        internal int Duration
        {
            get { return Decimal.ToInt32(udDuration.Value); }
            set { udDuration.Value = (decimal)value; }
        }
        internal bool IsAverage
        {
            get { return chkAverage.Checked; }
            set { chkAverage.Checked = value; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (!(0 <= udMin.Value && udMin.Value <= 100))
            {
                MessageBox.Show("Illegal Mix");
                return;
            }
            if (!(0 <= udMax.Value && udMax.Value <= 100))
            {
                MessageBox.Show("Illegal Max");
                return;
            }
            if( udDuration.Value <= 0)
            {
                MessageBox.Show("Illegal Duration");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void chkAverage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }
        void UpdateDialog()
        {
            string message = string.Format(Properties.Resources.STR_CPU_USAGE,
                MinCpuUsage, MaxCpuUsage, 
                IsAverage ? Properties.Resources.STR_IN_AVERAGE : Properties.Resources.STR_CONSECUTIVELY,
                Duration);
            txtExplanation.Text = message;
        }

        private void udMin_ValueChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void udMax_ValueChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void udDuration_ValueChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void udDuration_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDialog();
        }

        private void udMax_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDialog();
        }

        private void udMin_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDialog();
        }
    }
}

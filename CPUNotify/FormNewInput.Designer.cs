namespace CPUNotify
{
    partial class FormNewInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewInput));
            this.udMin = new System.Windows.Forms.NumericUpDown();
            this.udMax = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.udDuration = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.chkAverage = new System.Windows.Forms.CheckBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // udMin
            // 
            resources.ApplyResources(this.udMin, "udMin");
            this.udMin.Name = "udMin";
            this.udMin.ValueChanged += new System.EventHandler(this.udMin_ValueChanged);
            this.udMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udMin_KeyUp);
            // 
            // udMax
            // 
            resources.ApplyResources(this.udMax, "udMax");
            this.udMax.Name = "udMax";
            this.udMax.ValueChanged += new System.EventHandler(this.udMax_ValueChanged);
            this.udMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udMax_KeyUp);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // udDuration
            // 
            resources.ApplyResources(this.udDuration, "udDuration");
            this.udDuration.Name = "udDuration";
            this.udDuration.ValueChanged += new System.EventHandler(this.udDuration_ValueChanged);
            this.udDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udDuration_KeyUp);
            // 
            // lblMin
            // 
            resources.ApplyResources(this.lblMin, "lblMin");
            this.lblMin.Name = "lblMin";
            // 
            // lblMax
            // 
            resources.ApplyResources(this.lblMax, "lblMax");
            this.lblMax.Name = "lblMax";
            // 
            // lblDuration
            // 
            resources.ApplyResources(this.lblDuration, "lblDuration");
            this.lblDuration.Name = "lblDuration";
            // 
            // chkAverage
            // 
            resources.ApplyResources(this.chkAverage, "chkAverage");
            this.chkAverage.Name = "chkAverage";
            this.chkAverage.UseVisualStyleBackColor = true;
            this.chkAverage.CheckedChanged += new System.EventHandler(this.chkAverage_CheckedChanged);
            // 
            // txtExplanation
            // 
            resources.ApplyResources(this.txtExplanation, "txtExplanation");
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.ReadOnly = true;
            // 
            // FormNewInput
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.chkAverage);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.udDuration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.udMax);
            this.Controls.Add(this.udMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.udMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown udMin;
        private System.Windows.Forms.NumericUpDown udMax;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown udDuration;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.CheckBox chkAverage;
        private System.Windows.Forms.TextBox txtExplanation;
    }
}
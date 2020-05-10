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
            this.udMin.Location = new System.Drawing.Point(86, 14);
            this.udMin.Name = "udMin";
            this.udMin.Size = new System.Drawing.Size(99, 20);
            this.udMin.TabIndex = 0;
            this.udMin.ValueChanged += new System.EventHandler(this.udMin_ValueChanged);
            this.udMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udMin_KeyUp);
            // 
            // udMax
            // 
            this.udMax.Location = new System.Drawing.Point(86, 41);
            this.udMax.Name = "udMax";
            this.udMax.Size = new System.Drawing.Size(99, 20);
            this.udMax.TabIndex = 0;
            this.udMax.ValueChanged += new System.EventHandler(this.udMax_ValueChanged);
            this.udMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udMax_KeyUp);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(311, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(392, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // udDuration
            // 
            this.udDuration.Location = new System.Drawing.Point(86, 66);
            this.udDuration.Name = "udDuration";
            this.udDuration.Size = new System.Drawing.Size(99, 20);
            this.udDuration.TabIndex = 3;
            this.udDuration.ValueChanged += new System.EventHandler(this.udDuration_ValueChanged);
            this.udDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.udDuration_KeyUp);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(12, 16);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "&Min:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 43);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 13);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Ma&x:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 68);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "&Duration:";
            // 
            // chkAverage
            // 
            this.chkAverage.AutoSize = true;
            this.chkAverage.Location = new System.Drawing.Point(15, 92);
            this.chkAverage.Name = "chkAverage";
            this.chkAverage.Size = new System.Drawing.Size(119, 17);
            this.chkAverage.TabIndex = 7;
            this.chkAverage.Text = "&Use Average  Ratio";
            this.chkAverage.UseVisualStyleBackColor = true;
            this.chkAverage.CheckedChanged += new System.EventHandler(this.chkAverage_CheckedChanged);
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(216, 12);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.ReadOnly = true;
            this.txtExplanation.Size = new System.Drawing.Size(251, 93);
            this.txtExplanation.TabIndex = 8;
            // 
            // FormNewInput
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(479, 167);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CPUNotify Condition";
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
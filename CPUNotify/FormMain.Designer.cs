namespace CPUNotify
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtCpuUsage = new System.Windows.Forms.TextBox();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtArg = new System.Windows.Forms.TextBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblArg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(12, 9);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(66, 13);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "&CPU Usage:";
            // 
            // txtCpuUsage
            // 
            this.txtCpuUsage.Location = new System.Drawing.Point(15, 25);
            this.txtCpuUsage.Name = "txtCpuUsage";
            this.txtCpuUsage.ReadOnly = true;
            this.txtCpuUsage.Size = new System.Drawing.Size(488, 20);
            this.txtCpuUsage.TabIndex = 1;
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(23, 185);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(480, 20);
            this.txtApp.TabIndex = 2;
            // 
            // txtArg
            // 
            this.txtArg.Location = new System.Drawing.Point(23, 229);
            this.txtArg.Name = "txtArg";
            this.txtArg.Size = new System.Drawing.Size(480, 20);
            this.txtArg.TabIndex = 3;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(20, 169);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(29, 13);
            this.lblApp.TabIndex = 4;
            this.lblApp.Text = "&App:";
            // 
            // lblArg
            // 
            this.lblArg.AutoSize = true;
            this.lblArg.Location = new System.Drawing.Point(20, 213);
            this.lblArg.Name = "lblArg";
            this.lblArg.Size = new System.Drawing.Size(26, 13);
            this.lblArg.TabIndex = 5;
            this.lblArg.Text = "Ar&g:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 347);
            this.Controls.Add(this.lblArg);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.txtArg);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.txtCpuUsage);
            this.Controls.Add(this.lblCPU);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox txtCpuUsage;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtArg;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblArg;
    }
}


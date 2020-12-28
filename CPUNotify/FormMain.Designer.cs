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
            this.lblRangeAndDuration = new System.Windows.Forms.Label();
            this.txtRangeAndDuration = new System.Windows.Forms.TextBox();
            this.btnBrowseApp = new System.Windows.Forms.Button();
            this.btnBrowseArg = new System.Windows.Forms.Button();
            this.btnTestLaunch = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
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
            this.txtApp.Location = new System.Drawing.Point(15, 185);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(488, 20);
            this.txtApp.TabIndex = 2;
            // 
            // txtArg
            // 
            this.txtArg.Location = new System.Drawing.Point(15, 229);
            this.txtArg.Name = "txtArg";
            this.txtArg.Size = new System.Drawing.Size(488, 20);
            this.txtArg.TabIndex = 3;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(12, 169);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(29, 13);
            this.lblApp.TabIndex = 4;
            this.lblApp.Text = "&App:";
            // 
            // lblArg
            // 
            this.lblArg.AutoSize = true;
            this.lblArg.Location = new System.Drawing.Point(12, 213);
            this.lblArg.Name = "lblArg";
            this.lblArg.Size = new System.Drawing.Size(26, 13);
            this.lblArg.TabIndex = 5;
            this.lblArg.Text = "Ar&g:";
            // 
            // lblRangeAndDuration
            // 
            this.lblRangeAndDuration.AutoSize = true;
            this.lblRangeAndDuration.Location = new System.Drawing.Point(12, 48);
            this.lblRangeAndDuration.Name = "lblRangeAndDuration";
            this.lblRangeAndDuration.Size = new System.Drawing.Size(103, 13);
            this.lblRangeAndDuration.TabIndex = 6;
            this.lblRangeAndDuration.Text = "&Range and Duration";
            // 
            // txtRangeAndDuration
            // 
            this.txtRangeAndDuration.Location = new System.Drawing.Point(15, 64);
            this.txtRangeAndDuration.Name = "txtRangeAndDuration";
            this.txtRangeAndDuration.ReadOnly = true;
            this.txtRangeAndDuration.Size = new System.Drawing.Size(488, 20);
            this.txtRangeAndDuration.TabIndex = 7;
            // 
            // btnBrowseApp
            // 
            this.btnBrowseApp.Location = new System.Drawing.Point(509, 185);
            this.btnBrowseApp.Name = "btnBrowseApp";
            this.btnBrowseApp.Size = new System.Drawing.Size(36, 20);
            this.btnBrowseApp.TabIndex = 8;
            this.btnBrowseApp.Text = "&...";
            this.btnBrowseApp.UseVisualStyleBackColor = true;
            this.btnBrowseApp.Click += new System.EventHandler(this.btnBrowseApp_Click);
            // 
            // btnBrowseArg
            // 
            this.btnBrowseArg.Location = new System.Drawing.Point(509, 229);
            this.btnBrowseArg.Name = "btnBrowseArg";
            this.btnBrowseArg.Size = new System.Drawing.Size(36, 20);
            this.btnBrowseArg.TabIndex = 9;
            this.btnBrowseArg.Text = "&...";
            this.btnBrowseArg.UseVisualStyleBackColor = true;
            this.btnBrowseArg.Click += new System.EventHandler(this.btnBrowseArg_Click);
            // 
            // btnTestLaunch
            // 
            this.btnTestLaunch.Location = new System.Drawing.Point(417, 258);
            this.btnTestLaunch.Name = "btnTestLaunch";
            this.btnTestLaunch.Size = new System.Drawing.Size(128, 23);
            this.btnTestLaunch.TabIndex = 10;
            this.btnTestLaunch.Text = "&Test Launch";
            this.btnTestLaunch.UseVisualStyleBackColor = true;
            this.btnTestLaunch.Click += new System.EventHandler(this.btnTestLaunch_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(15, 103);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(488, 23);
            this.btnPause.TabIndex = 11;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(417, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(15, 307);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(109, 31);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(557, 350);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnTestLaunch);
            this.Controls.Add(this.btnBrowseArg);
            this.Controls.Add(this.btnBrowseApp);
            this.Controls.Add(this.txtRangeAndDuration);
            this.Controls.Add(this.lblRangeAndDuration);
            this.Controls.Add(this.lblArg);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.txtArg);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.txtCpuUsage);
            this.Controls.Add(this.lblCPU);
            this.MinimumSize = new System.Drawing.Size(573, 389);
            this.Name = "FormMain";
            this.Text = "CPUNotify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.Label lblRangeAndDuration;
        private System.Windows.Forms.TextBox txtRangeAndDuration;
        private System.Windows.Forms.Button btnBrowseApp;
        private System.Windows.Forms.Button btnBrowseArg;
        private System.Windows.Forms.Button btnTestLaunch;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
    }
}


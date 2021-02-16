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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtCpuUsage = new System.Windows.Forms.TextBox();
            this.lblRangeAndDuration = new System.Windows.Forms.Label();
            this.txtRangeAndDuration = new System.Windows.Forms.TextBox();
            this.btnTestLaunch = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.txtNotification = new System.Windows.Forms.TextBox();
            this.btnEditNotification = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblCPU
            // 
            resources.ApplyResources(this.lblCPU, "lblCPU");
            this.lblCPU.Name = "lblCPU";
            // 
            // txtCpuUsage
            // 
            resources.ApplyResources(this.txtCpuUsage, "txtCpuUsage");
            this.txtCpuUsage.Name = "txtCpuUsage";
            this.txtCpuUsage.ReadOnly = true;
            // 
            // lblRangeAndDuration
            // 
            resources.ApplyResources(this.lblRangeAndDuration, "lblRangeAndDuration");
            this.lblRangeAndDuration.Name = "lblRangeAndDuration";
            // 
            // txtRangeAndDuration
            // 
            resources.ApplyResources(this.txtRangeAndDuration, "txtRangeAndDuration");
            this.txtRangeAndDuration.Name = "txtRangeAndDuration";
            this.txtRangeAndDuration.ReadOnly = true;
            // 
            // btnTestLaunch
            // 
            resources.ApplyResources(this.btnTestLaunch, "btnTestLaunch");
            this.btnTestLaunch.Name = "btnTestLaunch";
            this.btnTestLaunch.UseVisualStyleBackColor = true;
            this.btnTestLaunch.Click += new System.EventHandler(this.btnTestLaunch_Click);
            // 
            // btnPause
            // 
            resources.ApplyResources(this.btnPause, "btnPause");
            this.btnPause.Name = "btnPause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblNotification
            // 
            resources.ApplyResources(this.lblNotification, "lblNotification");
            this.lblNotification.Name = "lblNotification";
            // 
            // txtNotification
            // 
            resources.ApplyResources(this.txtNotification, "txtNotification");
            this.txtNotification.Name = "txtNotification";
            // 
            // btnEditNotification
            // 
            resources.ApplyResources(this.btnEditNotification, "btnEditNotification");
            this.btnEditNotification.Name = "btnEditNotification";
            this.btnEditNotification.UseVisualStyleBackColor = true;
            this.btnEditNotification.Click += new System.EventHandler(this.btnEditNotification_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStopSound
            // 
            resources.ApplyResources(this.btnStopSound, "btnStopSound");
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnStopSound);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEditNotification);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnTestLaunch);
            this.Controls.Add(this.txtRangeAndDuration);
            this.Controls.Add(this.lblRangeAndDuration);
            this.Controls.Add(this.txtCpuUsage);
            this.Controls.Add(this.lblCPU);
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox txtCpuUsage;
        private System.Windows.Forms.Label lblRangeAndDuration;
        private System.Windows.Forms.TextBox txtRangeAndDuration;
        private System.Windows.Forms.Button btnTestLaunch;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.TextBox txtNotification;
        private System.Windows.Forms.Button btnEditNotification;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStopSound;
    }
}


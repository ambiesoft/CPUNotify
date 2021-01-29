﻿namespace CPUNotify
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
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(12, 9);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(66, 13);
            this.lblCPU.TabIndex = 100;
            this.lblCPU.Text = "&CPU Usage:";
            // 
            // txtCpuUsage
            // 
            this.txtCpuUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuUsage.Location = new System.Drawing.Point(15, 25);
            this.txtCpuUsage.Name = "txtCpuUsage";
            this.txtCpuUsage.ReadOnly = true;
            this.txtCpuUsage.Size = new System.Drawing.Size(530, 20);
            this.txtCpuUsage.TabIndex = 200;
            // 
            // lblRangeAndDuration
            // 
            this.lblRangeAndDuration.AutoSize = true;
            this.lblRangeAndDuration.Location = new System.Drawing.Point(12, 48);
            this.lblRangeAndDuration.Name = "lblRangeAndDuration";
            this.lblRangeAndDuration.Size = new System.Drawing.Size(103, 13);
            this.lblRangeAndDuration.TabIndex = 300;
            this.lblRangeAndDuration.Text = "&Range and Duration";
            // 
            // txtRangeAndDuration
            // 
            this.txtRangeAndDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRangeAndDuration.Location = new System.Drawing.Point(15, 64);
            this.txtRangeAndDuration.Name = "txtRangeAndDuration";
            this.txtRangeAndDuration.ReadOnly = true;
            this.txtRangeAndDuration.Size = new System.Drawing.Size(530, 20);
            this.txtRangeAndDuration.TabIndex = 400;
            // 
            // btnTestLaunch
            // 
            this.btnTestLaunch.Location = new System.Drawing.Point(15, 296);
            this.btnTestLaunch.Name = "btnTestLaunch";
            this.btnTestLaunch.Size = new System.Drawing.Size(128, 23);
            this.btnTestLaunch.TabIndex = 900;
            this.btnTestLaunch.Text = "&Test Launch";
            this.btnTestLaunch.UseVisualStyleBackColor = true;
            this.btnTestLaunch.Click += new System.EventHandler(this.btnTestLaunch_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(15, 90);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(530, 23);
            this.btnPause.TabIndex = 500;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(417, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 31);
            this.btnClose.TabIndex = 1200;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(15, 352);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(128, 31);
            this.btnAbout.TabIndex = 1100;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(12, 152);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(60, 13);
            this.lblNotification.TabIndex = 700;
            this.lblNotification.Text = "&Notification";
            // 
            // txtNotification
            // 
            this.txtNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotification.Enabled = false;
            this.txtNotification.Location = new System.Drawing.Point(15, 168);
            this.txtNotification.Multiline = true;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(530, 122);
            this.txtNotification.TabIndex = 800;
            // 
            // btnEditNotification
            // 
            this.btnEditNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNotification.Location = new System.Drawing.Point(417, 296);
            this.btnEditNotification.Name = "btnEditNotification";
            this.btnEditNotification.Size = new System.Drawing.Size(128, 23);
            this.btnEditNotification.TabIndex = 1000;
            this.btnEditNotification.Text = "&Edit";
            this.btnEditNotification.UseVisualStyleBackColor = true;
            this.btnEditNotification.Click += new System.EventHandler(this.btnEditNotification_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(15, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(530, 23);
            this.btnReset.TabIndex = 600;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStopSound
            // 
            this.btnStopSound.Location = new System.Drawing.Point(149, 296);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(128, 23);
            this.btnStopSound.TabIndex = 950;
            this.btnStopSound.Text = "&Stop Sound";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(557, 395);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(573, 434);
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


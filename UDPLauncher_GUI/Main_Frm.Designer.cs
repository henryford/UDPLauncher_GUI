namespace UDPLauncher_GUI
{
    partial class UDPLauncher_Main_Frm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDPLauncher_Main_Frm));
            this.btStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMSTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMSTray_txtStatus = new System.Windows.Forms.ToolStripTextBox();
            this.cMSTray_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSTray_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSTray_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.cMSTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(240, 36);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(75, 23);
            this.btStartStop.TabIndex = 0;
            this.btStartStop.Text = "Run";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(74, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Not Running";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(331, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Settings";
            this.toolStripButton1.Click += new System.EventHandler(this.tSSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nIcon
            // 
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "UDPLauncher";
            this.nIcon.Visible = true;
            this.nIcon.Click += new System.EventHandler(this.nIcon_Click);
            this.nIcon.DoubleClick += new System.EventHandler(this.nIcon_DoubleClick);
            // 
            // cMSTray
            // 
            this.cMSTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMSTray_txtStatus,
            this.toolStripSeparator2,
            this.cMSTray_Start,
            this.cMSTray_Stop,
            this.cMSTray_Exit});
            this.cMSTray.Name = "cMSTray";
            this.cMSTray.Size = new System.Drawing.Size(163, 123);
            this.cMSTray.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMSTray_ItemClicked);
            // 
            // cMSTray_txtStatus
            // 
            this.cMSTray_txtStatus.Name = "cMSTray_txtStatus";
            this.cMSTray_txtStatus.ReadOnly = true;
            this.cMSTray_txtStatus.Size = new System.Drawing.Size(100, 23);
            this.cMSTray_txtStatus.Text = "Not Running";
            // 
            // cMSTray_Start
            // 
            this.cMSTray_Start.Name = "cMSTray_Start";
            this.cMSTray_Start.Size = new System.Drawing.Size(162, 22);
            this.cMSTray_Start.Text = "Start the Listener";
            // 
            // cMSTray_Stop
            // 
            this.cMSTray_Stop.Name = "cMSTray_Stop";
            this.cMSTray_Stop.Size = new System.Drawing.Size(162, 22);
            this.cMSTray_Stop.Text = "Stop the Listener";
            // 
            // cMSTray_Exit
            // 
            this.cMSTray_Exit.Name = "cMSTray_Exit";
            this.cMSTray_Exit.Size = new System.Drawing.Size(162, 22);
            this.cMSTray_Exit.Text = "Close Listener";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // UDPLauncher_Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 88);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStartStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UDPLauncher_Main_Frm";
            this.Text = "UDPLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UDPLauncher_Main_Frm_FormClosing);
            this.Resize += new System.EventHandler(this.UDPLauncher_Main_Frm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cMSTray.ResumeLayout(false);
            this.cMSTray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.ContextMenuStrip cMSTray;
        private System.Windows.Forms.ToolStripTextBox cMSTray_txtStatus;
        private System.Windows.Forms.ToolStripMenuItem cMSTray_Start;
        private System.Windows.Forms.ToolStripMenuItem cMSTray_Stop;
        private System.Windows.Forms.ToolStripMenuItem cMSTray_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


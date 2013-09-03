namespace UDPLauncher_GUI
{
    partial class Settings_Frm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.chkEvent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProg = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtXBMCPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkExitIf = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(444, 221);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(363, 221);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // chkEvent
            // 
            this.chkEvent.AutoSize = true;
            this.chkEvent.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkEvent.Location = new System.Drawing.Point(15, 160);
            this.chkEvent.Name = "chkEvent";
            this.chkEvent.Size = new System.Drawing.Size(117, 18);
            this.chkEvent.TabIndex = 5;
            this.chkEvent.Text = "Use XBMC Event?";
            this.chkEvent.UseVisualStyleBackColor = true;
            this.chkEvent.CheckedChanged += new System.EventHandler(this.chkEvent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Path of the Program to launch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "XBMC Hostname:";
            // 
            // txtProg
            // 
            this.txtProg.Location = new System.Drawing.Point(15, 24);
            this.txtProg.Name = "txtProg";
            this.txtProg.Size = new System.Drawing.Size(426, 20);
            this.txtProg.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(444, 22);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(18, 199);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(115, 20);
            this.txtHost.TabIndex = 6;
            // 
            // txtXBMCPort
            // 
            this.txtXBMCPort.Location = new System.Drawing.Point(133, 199);
            this.txtXBMCPort.Name = "txtXBMCPort";
            this.txtXBMCPort.Size = new System.Drawing.Size(48, 20);
            this.txtXBMCPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(130, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(187, 199);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(115, 20);
            this.txtUser.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(184, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username (if used):";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(311, 199);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(115, 20);
            this.txtPW.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(308, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password (if used):";
            // 
            // chkExitIf
            // 
            this.chkExitIf.AutoSize = true;
            this.chkExitIf.Font = new System.Drawing.Font("Calibri", 9F);
            this.chkExitIf.Location = new System.Drawing.Point(15, 50);
            this.chkExitIf.Name = "chkExitIf";
            this.chkExitIf.Size = new System.Drawing.Size(225, 18);
            this.chkExitIf.TabIndex = 2;
            this.chkExitIf.Text = "Exit the above program if is running?";
            this.chkExitIf.UseVisualStyleBackColor = true;
            this.chkExitIf.CheckedChanged += new System.EventHandler(this.chkExitIf_Changed);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(15, 97);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 20);
            this.txtPort.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Port on which I\'ll listen for packets:";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(15, 123);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(205, 17);
            this.chkAutoStart.TabIndex = 4;
            this.chkAutoStart.Text = "Start Listener when Program launches";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // Settings_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 246);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkExitIf);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXBMCPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.txtProg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEvent);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Name = "Settings_Frm";
            this.Text = "UDPLauncher - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox chkEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProg;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtXBMCPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkExitIf;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAutoStart;
    }
}
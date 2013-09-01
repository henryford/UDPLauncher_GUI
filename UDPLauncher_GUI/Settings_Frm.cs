using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPLauncher_GUI.Properties;

namespace UDPLauncher_GUI
{
    public partial class Settings_Frm : Form
    {
        #region HelpStuff
        string XBMCPassword, XBMCUsername, ProgramToLaunch, XBMCHost, XBMCEvent;
        int RunningPort, XBMCPort;
        bool ExitIfOpen, UseEvent, Autostart;

        //Helper functions
        private void LoadSettings()
        {
            XBMCUsername = Settings.Default.XBMCUser;
            XBMCPassword = Settings.Default.XBMCPassword;
            XBMCHost = Settings.Default.XBMCHost;
            XBMCEvent = Settings.Default.XBMCEvent;
            XBMCPort = Settings.Default.XBMCPort;
            RunningPort = Settings.Default.PortToListenTo;
            ProgramToLaunch = Settings.Default.ProgramToLaunch;
            ExitIfOpen = Settings.Default.ExitIfOpen;
            UseEvent = Settings.Default.UseXBMCEvent;
            Autostart = Settings.Default.Autostart;

            this.txtProg.Text = this.ProgramToLaunch;
            this.txtPort.Text = this.RunningPort.ToString();
            this.txtHost.Text = this.XBMCHost;
            this.txtXBMCPort.Text = this.XBMCPort.ToString();
            this.txtUser.Text = this.XBMCUsername;
            this.txtPW.Text = this.XBMCPassword;

            if (!this.UseEvent)
            {
                this.chkEvent.Checked = false;
                this.txtHost.Enabled = false;
                this.txtUser.Enabled = false;
                this.txtPW.Enabled = false;
                this.txtXBMCPort.Enabled = false;
            }
            else
            {
                this.chkEvent.Checked = true;
                this.txtHost.Enabled = true;
                this.txtUser.Enabled = true;
                this.txtPW.Enabled = true;
                this.txtXBMCPort.Enabled = true;
            }

            if (!this.ExitIfOpen)
                this.chkExitIf.Checked = false;
            else
                this.chkExitIf.Checked = true;

            if (!this.Autostart)
                this.chkAutoStart.Checked = false;
            else
                this.chkAutoStart.Checked = true;

            this.Update();
        }

        private void SaveSettings()
        {
            if (UseEvent)
            {
                if (XBMCHost == "" || XBMCPort == 0)
                {
                    MessageBox.Show("Please make sure that you enter both - Hostname and Port for XBMC - correctly.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (RunningPort == 0 || ProgramToLaunch == "")
            {
                MessageBox.Show("Please make sure that you enter both - Path for the Program to launch and Port to listen to - correctly.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.XBMCUser = XBMCUsername;
            Settings.Default.XBMCPassword = XBMCPassword;
            Settings.Default.XBMCHost = XBMCHost;
            Settings.Default.XBMCEvent = XBMCEvent;
            Settings.Default.XBMCPort = XBMCPort;
            Settings.Default.PortToListenTo = RunningPort;
            Settings.Default.ProgramToLaunch = ProgramToLaunch;
            Settings.Default.ExitIfOpen = ExitIfOpen;
            Settings.Default.UseXBMCEvent = UseEvent;
            Settings.Default.Autostart = Autostart;
            Settings.Default.Save();
        }
        #endregion


        #region FormHandling
        //Form related stuff
        public Settings_Frm()
        {
            InitializeComponent();
            this.LoadSettings();
        }


        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog filediag = new OpenFileDialog();
            filediag.CheckFileExists = true;
            
            if (filediag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProgramToLaunch = filediag.FileName;
                this.txtProg.Text = filediag.FileName;
                this.Update();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            XBMCUsername = txtUser.Text;
            XBMCPassword = txtPW.Text;
            XBMCHost = txtHost.Text;
            int.TryParse(txtXBMCPort.Text, out XBMCPort);
            if (XBMCPort == 0 && UseEvent)
            {
                MessageBox.Show("Please enter a correct value for the port, not saving settings.");
                return;
            }

            ProgramToLaunch = txtProg.Text;
            int.TryParse(txtPort.Text, out RunningPort);
            if (RunningPort == 0)
            {
                MessageBox.Show("Please enter a correct value for the port to listen to, not saving settings.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chkEvent.Checked)
                UseEvent = true;
            else
                UseEvent = false;

            if (chkExitIf.Checked)
                ExitIfOpen = true;
            else
                ExitIfOpen = false;

            this.SaveSettings();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void chkExitIf_Changed(object sender, EventArgs e)
        {
            if (chkExitIf.Checked)
                this.ExitIfOpen = true;
            else
                this.ExitIfOpen = false;
        }

        private void chkEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.chkEvent.Checked)
            {
                this.UseEvent = false;
                this.txtHost.Enabled = false;
                this.txtUser.Enabled = false;
                this.txtPW.Enabled = false;
                this.txtXBMCPort.Enabled = false;
            }
            else
            {
                this.UseEvent = true;
                this.txtHost.Enabled = true;
                this.txtUser.Enabled = true;
                this.txtPW.Enabled = true;
                this.txtXBMCPort.Enabled = true;
            }

            this.Update();
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoStart.Checked)
                Autostart = true;
            else
                Autostart = false;
        }

    }
        #endregion
}

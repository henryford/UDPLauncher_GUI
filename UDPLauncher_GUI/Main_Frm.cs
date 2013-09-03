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
using System.Threading;

namespace UDPLauncher_GUI
{
    public partial class UDPLauncher_Main_Frm : Form
    {
        string XBMCPassword, XBMCUsername, ProgramToLaunch, XBMCHost, XBMCEvent;
        int RunningPort, XBMCPort;
        bool ExitIfOpen, UseEvent, Autostart;
        bool running;
        UDPListener Listener;
        Thread ListenerThread;
    
        public UDPLauncher_Main_Frm()
        {
            InitializeComponent();

            nIcon.Icon = Resources.picBulbOff;
            nIcon.BalloonTipText = "Listener not running.";
            nIcon.BalloonTipTitle = "UDPLauncher";
            nIcon.ContextMenuStrip = cMSTray;
            cMSTray_txtStatus.Text = "Not Running";
            cMSTray_Stop.Enabled = false;

            this.LoadSettings();
            running = false;
            Listener = new UDPListener(ProgramToLaunch, RunningPort, ExitIfOpen, UseEvent, XBMCUsername, XBMCPassword, XBMCHost, XBMCPort, XBMCEvent);

            if (Autostart)
                this.StartListenerThread();
        }

        private void tSSettings_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings_Frm();
            SettingsForm.Icon = Resources.picBulbOff;

            if (SettingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadSettings();
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (!running)
                this.StartListenerThread();
            else
                this.StopListenerThread();
        }

        private void UDPLauncher_Main_Frm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void UDPLauncher_Main_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                Listener.StopListener();
                ListenerThread.Interrupt();
                ListenerThread.Join();
            }
        }

        private void nIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void nIcon_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void cMSTray_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == cMSTray_Start.Name)
                this.StartListenerThread();
            else if (e.ClickedItem.Name == cMSTray_Stop.Name)
                this.StopListenerThread();
            else if (e.ClickedItem.Name == cMSTray_Exit.Name)
                this.Close();
        }

        private void StartListenerThread()
        {
            btStartStop.Text = "Stop";
            lblStatus.Text = "Running";
            cMSTray_Stop.Enabled = true;
            cMSTray_Start.Enabled = false;
            lblStatus.ForeColor = Color.Green;
            ListenerThread = new Thread(Listener.StartListener);
            ListenerThread.Start();
            running = true;
            this.Icon = Resources.picBulbOn;
            nIcon.Icon = Resources.picBulbOn;
            nIcon.BalloonTipText = "Listener running.";
            cMSTray_txtStatus.Text = "Running";
            this.Update();
        }

        private void StopListenerThread()
        {
            Listener.StopListener();
            ListenerThread.Interrupt();
            ListenerThread.Join();
            running = false;
            btStartStop.Text = "Start";
            lblStatus.Text = "Not Running.";
            cMSTray_Start.Enabled = true;
            cMSTray_Stop.Enabled = false;
            lblStatus.ForeColor = Color.Red;
            this.Icon = Resources.picBulbOff;
            nIcon.Icon = Resources.picBulbOff;
            nIcon.BalloonTipText = "Listener not running.";
            cMSTray_txtStatus.Text = "Not Running";
            this.Update();
        }

        private void LoadSettings()
        {
            //Reload Settings
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

            if (running)
            {
                Listener.StopListener();
                ListenerThread.Interrupt();
                ListenerThread.Join();
                running = false;
                btStartStop.Enabled = false;
                lblStatus.Text = "Restarting...";
                this.Update();

                Thread.Sleep(1000);

                Listener = new UDPListener(ProgramToLaunch, RunningPort, ExitIfOpen, UseEvent, XBMCUsername, XBMCPassword, XBMCHost, XBMCPort, XBMCEvent);
                StartListenerThread();
            }
        }
    }
}

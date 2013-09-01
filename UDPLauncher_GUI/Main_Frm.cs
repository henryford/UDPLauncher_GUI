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
            this.LoadSettings();
            running = false;
            Listener = new UDPListener(ProgramToLaunch, RunningPort, ExitIfOpen, UseEvent, XBMCUsername, XBMCPassword, XBMCHost, XBMCPort, XBMCEvent);

            if (Autostart)
            {
                btStartStop.Text = "Stop";
                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.Green;
                ListenerThread = new Thread(Listener.StartListener);
                ListenerThread.Start();
                running = true;
            }
        }

        private void tSSettings_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings_Frm();

            if (SettingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.LoadSettings();
            }
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
                btStartStop.Text = "Stop";
                btStartStop.Enabled = true;
                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.Green;
                ListenerThread = new Thread(Listener.StartListener);
                ListenerThread.Start();
                running = true;
            }
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                btStartStop.Text = "Stop";
                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.Green;
                ListenerThread = new Thread(Listener.StartListener);
                ListenerThread.Start();
                running = true;
            }
            else
            {
                Listener.StopListener();
                ListenerThread.Interrupt();
                ListenerThread.Join();
                running = false;
                btStartStop.Text = "Start";
                lblStatus.Text = "Not Running.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void UDPLauncher_Main_Frm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void nIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
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
    }
}

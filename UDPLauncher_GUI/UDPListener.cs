using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace UDPLauncher_GUI
{
    class UDPListener
    {
        string _XBMCPassword, _XBMCUsername, _ProgramToLaunch, _XBMCHost, _XBMCEvent;
        int _RunningPort, _XBMCPort;
        bool _ExitIfOpen, _UseEvent;
        volatile bool _flag;
        UdpClient client;

        public UDPListener(string ProgramToLaunch, int RunningPort, bool ExitIfOpen, bool UseEvent, string XBMCUsername, string XBMCPassword, string XBMCHost, int XBMCPort, string XBMCEvent)
        {
            _ProgramToLaunch = ProgramToLaunch;
            _RunningPort = RunningPort;

            _ExitIfOpen = ExitIfOpen;
            _UseEvent = UseEvent;

            _XBMCUsername = XBMCUsername;
            _XBMCPassword = XBMCPassword;
            _XBMCHost = XBMCHost;
            _XBMCPort = XBMCPort;
            _XBMCEvent = XBMCEvent;
        }

        private bool IsProcessOpen(string CheckProgram)
        {
            ManagementObjectCollection objects = new ManagementObjectSearcher("SELECT * FROM WIN32_Process").Get();
            if (objects != null)
            {
                foreach (ManagementObject obj in objects)
                {
                    if (((string)obj["ExecutablePath"]) != null)
                    {
                        string str = (string)obj["ExecutablePath"];
                        if (str.Contains(CheckProgram))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool IsProcessOpen(string CheckProgram, out uint RunningID)
        {
            ManagementObjectCollection objects = new ManagementObjectSearcher("SELECT ProcessID,ExecutablePath FROM WIN32_Process").Get();
            if (objects != null)
            {
                foreach (ManagementObject obj2 in objects)
                {
                    if (((string)obj2["ExecutablePath"]) != null)
                    {
                        string str = (string)obj2["ExecutablePath"];
                        if (str.Contains(CheckProgram))
                        {
                            RunningID = (uint)obj2["ProcessID"];
                            return true;
                        }
                    }
                }
            }
            RunningID = 0;
            return false;
        }

        public void StartListener()
        {
            try
            {
                client = new UdpClient(_RunningPort);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, _RunningPort);
                Process process = new Process { StartInfo = { FileName = _ProgramToLaunch } };
                _flag = false;

                while (!_flag)
                {
                    try
                    {
                        if (client.Receive(ref remoteEP) != null)
                        {
                            if (_ExitIfOpen)
                            {
                                uint num;
                                if (this.IsProcessOpen(_ProgramToLaunch, out num))
                                    Process.GetProcessById(Convert.ToInt32(num)).Kill();
                                else
                                    process.Start();
                            }
                            else if (this.IsProcessOpen(_ProgramToLaunch))
                            {
                                //Some kind of action if the Program is running, but ExitIfOpen is not set?
                            }
                            else
                                process.Start();

                            if (_UseEvent && this.IsProcessOpen("XBMC.exe"))
                            {
                                //Have to rewrite this in the end - webapi is not existing anymore, so we'll have to use JSON
                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Concat(new object[] { "http://", _XBMCHost, ":", _XBMCPort, "/xbmcCmds/xbmcHttp?command=", _XBMCEvent }));
                                if ((_XBMCUsername != "") && (_XBMCPassword != ""))
                                {
                                    request.Credentials = new NetworkCredential(_XBMCUsername, _XBMCPassword);
                                }

                                try
                                {
                                    request.GetResponse();
                                }
                                catch (WebException exception)
                                {
                                    System.Windows.Forms.MessageBox.Show("We received an error while launching the XBMCEvent: " + exception.Message, "ERROR!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                                    _flag = true;
                                }
                            }
                        }
                    }                    
                    catch (ThreadInterruptedException)
                    {
                        break;
                    }
                    catch (SocketException)
                    {
                        break;
                    }
                    catch (ThreadAbortException)
                    {
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("We received an error while listening for packages: " + exception.Message, "ERROR!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                _flag = true;
            }
        }

        public void StopListener()
        {
            client.Close();
            _flag = true;
            Thread.Sleep(30);
        }
    }
}

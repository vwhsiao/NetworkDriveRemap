using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Principal;

namespace Drive_Remap
{
    public partial class DriveRemap : Form
    {

        //List<CheckBox> drives = new List<CheckBox>();
        List<Drives> drives = new List<Drives>();
        bool allSelected = false;
        string netuse = "net use * ";
        string persistent = "/p:yes";
        string username = System.Environment.UserName;

        bool adminAccess = false;
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        public DriveRemap()
        {
            InitializeComponent();
            this.Text = "DriveRemap";
            
            label3.Text = "Hi "+username+ ",\n\nThis program will: \n 1. Disconnect all connected drives \n 2. Connect all drives selected in the \n     checkboxes below";
            label4.Text = "Please select all the drives you would like to \nconnect to:";

            drives.Add(new Drives(Summer, "\\\\dns1\\summer",true));
            drives.Add(new Drives(SCES, "\\\\dns2\\sces", false));
            drives.Add(new Drives(MeetingMatrix, "\\\\buzz\\meetingmatrix", true));
            drives.Add(new Drives(RoomViewer, "\\\\dns1\\rmviewer", true));
            drives.Add(new Drives(Home, "\\\\dns2\\home$\\%username%", false));

            Home.Text = "Home (" + username + ")";
        }

        //Confirm button click. Name isn't changed due to unsure problems. 
        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool dns1 = false;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;
            int selected = 0;
            for (int i = 0; i<drives.Count; i++)
            {
                if (drives[i].box.Checked)
                {
                    selected++;
                    if (drives[i].dns1)
                    {
                        dns1 = drives[i].dns1;
                    }
                }
                
            }
            if (selected == 0)
            {
                DisplayStatus("[Error] Please select at least 1 network drive.");
               
                return;
            }

            if (!studentCheck.Checked && password.Text.Trim().Length == 0)
            {
                if (dns1)
                {
                    DisplayStatus("Please input your password.");
                    return;
                }


            }
            if (selected > 0 )
            {
                DisplayStatus("[Action] Disconnecting all network drives.");
                RunCommand("net use * /delete /y");

                for (int i = 0; i < drives.Count; i++)
                {
                    WaitNSeconds(1);
                    if (drives[i].box.Checked)
                    {
                        DisplayStatus("[Log] Connecting to " + drives[i].box.Text + "...");
                        

                        string command = netuse + " " + drives[i].location;
                        if (drives[i].dns1)
                        {
                            if (studentCheck.Checked)
                            {
                                command += " /user:studentcenter.uci.edu\\reserver tumbleweed2011 "+persistent;
                            }
                            else
                            {
                                command += " /user:studentcenter.uci.edu\\" + username + " "+ password.Text+" "+persistent;
                            }
                            
                        }
                        else
                        {
                            command += " " + persistent;
                        }

                        RunCommand(command);
                        if (process.ExitCode!=0)
                        {
                            DisplayStatus("[Error] Incorrect dns1 Password");
                        }
                        else
                        {
                            DisplayStatus("[Log] Successfully connected to "+ drives[i].box.Text);
                            
                        }

                        for (int m = 0; m < (toolStripProgressBar1.Maximum / selected); m++)
                        {
                            toolStripProgressBar1.Value++;     
                        }
                    }
                }
                DisplayStatus("[Log] Finished reconnecting selected drives");
                DisplayStatus("============================================");
                RestartExplorer();
            }

        }

        private void DisplayStatus(string message)
        {
            statusBox.AppendText(message);
            statusBox.AppendText(Environment.NewLine);
        }

        //forces the thread to wait x seconds. the program likes to run in multithreading, which causes issues with CMD commands if they run at the same time.
        private void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        //If the "I am a student" checkbox is selected, the password textbox is disabled. 
        private void studentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!password.Enabled)
            {
                password.Enabled = true;
                return;
            }
            password.Enabled = false;
        }
        
        //runs cmd commands. Not really preferable, but its the fastest way to do it. 
        private void RunCommand(string command)
        {

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            process.StartInfo = startInfo;
            process.Start();
            while (!process.WaitForExit(3000))
            {
                process.Kill();
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TabMenu.SelectedTab.Name == "General")
                {
                    confirmButton_Click(sender, e);
                }
                else
                {
                    loginButton_Click(sender, e);
                }
            }
        }

        private void tab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!adminAccess)
                {
                    loginButton_Click(sender, e);
                    return;
                }
                else
                {
                    connectButton_Click(sender, e);
                }
            }
        }



        /*Selects all checkboxes for drive mapping, changes button appropriately, and allows for deselection of all checkboxes if needed.*/
        private void selectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drives.Count; i++)
            {
                if (!allSelected)
                {
                    drives[i].box.Checked = true;
                }
                else
                {
                    drives[i].box.Checked = false;
                }
            }
            allSelected = !allSelected;
            if (!allSelected)
            {
                selectAll.Text = "Select All";
            }
            else
            {
                selectAll.Text = "Deselect All";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminPassword.Text == "redactedpassword")
            {
                unlock();
                loginPanel.Enabled = false;
                adminAccess = true;
            }
            else
            {
                DisplayStatus("[ADMIN] Password incorrect.");
            }
            
            
        }
        private void unlock()
        {
            adminPanel.Visible = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            string command = netuse + " " + driveLocationText.Text;
            if (adminLoginUserNameText.Enabled == false)
            {
                command += " "+ persistent;
                RunCommand(command);
                toolStripProgressBar1.Value = 50;

                RestartExplorer();

                DisplayStatus("[ADMIN] Finished");
                toolStripProgressBar1.Value = 100;
            }
            else
            {
                command += " /user:" + adminLoginUserNameText.Text + " " + adminLoginPasswordText.Text + " " + persistent;
                RunCommand(command);

                toolStripProgressBar1.Value = 50;

                RestartExplorer();
                DisplayStatus("[ADMIN] Finished");
                toolStripProgressBar1.Value = 100;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (adminLoginPasswordText.Enabled)
            {
                adminLoginPasswordText.Enabled = false;
                adminLoginUserNameText.Enabled = false;
            }
            else
            {
                adminLoginPasswordText.Enabled = true;
                adminLoginUserNameText.Enabled = true;
            }
            

        }

        private void RestartExplorer()
        {
            var explorers = Process.GetProcessesByName("explorer");
            foreach (var thisExplorer in explorers)
            {
                thisExplorer.Kill();
            }
            WaitNSeconds(1);
            Process.Start("explorer.exe");
        }


    }

    /*Drives class. Holds the CheckBox object, string for the NCU location, and a boolean that says if it requires a studentcenter password.
     Not: not studentcenter1 password. */
    public class Drives
    {
        public CheckBox box;
        public string location;
        public bool dns1;
        public Drives(CheckBox _name, string _location, bool _dns1)
        {
            box = _name;
            location = _location;
            dns1 = _dns1;
        }
    }


}

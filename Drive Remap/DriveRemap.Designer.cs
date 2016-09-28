using System.Windows.Forms;

namespace Drive_Remap
{
    partial class DriveRemap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriveRemap));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.studentCheck = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.CheckBox();
            this.MeetingMatrix = new System.Windows.Forms.CheckBox();
            this.RoomViewer = new System.Windows.Forms.CheckBox();
            this.SCES = new System.Windows.Forms.CheckBox();
            this.Summer = new System.Windows.Forms.CheckBox();
            this.Admin = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adminLoginPasswordText = new System.Windows.Forms.TextBox();
            this.driveLocationText = new System.Windows.Forms.TextBox();
            this.DriveAddressLabel = new System.Windows.Forms.Label();
            this.adminPasswordLoginLabel = new System.Windows.Forms.Label();
            this.adminLoginUserNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.General.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Admin.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 751);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(493, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 20);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.confirmButton.Location = new System.Drawing.Point(93, 362);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(267, 41);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.General);
            this.TabMenu.Controls.Add(this.Admin);
            this.TabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TabMenu.Location = new System.Drawing.Point(20, 144);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(4);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(463, 453);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // General
            // 
            this.General.Controls.Add(this.label4);
            this.General.Controls.Add(this.studentCheck);
            this.General.Controls.Add(this.passwordLabel);
            this.General.Controls.Add(this.password);
            this.General.Controls.Add(this.confirmButton);
            this.General.Controls.Add(this.panel1);
            this.General.Location = new System.Drawing.Point(4, 27);
            this.General.Margin = new System.Windows.Forms.Padding(4);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(4);
            this.General.Size = new System.Drawing.Size(455, 422);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 14;
            // 
            // studentCheck
            // 
            this.studentCheck.AutoSize = true;
            this.studentCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.studentCheck.Location = new System.Drawing.Point(152, 293);
            this.studentCheck.Margin = new System.Windows.Forms.Padding(4);
            this.studentCheck.Name = "studentCheck";
            this.studentCheck.Size = new System.Drawing.Size(137, 24);
            this.studentCheck.TabIndex = 13;
            this.studentCheck.Text = "I am a student";
            this.studentCheck.UseVisualStyleBackColor = true;
            this.studentCheck.CheckedChanged += new System.EventHandler(this.studentCheck_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordLabel.Location = new System.Drawing.Point(42, 332);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(135, 18);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Domain Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(203, 329);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(196, 24);
            this.password.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.selectAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.MeetingMatrix);
            this.panel1.Controls.Add(this.RoomViewer);
            this.panel1.Controls.Add(this.SCES);
            this.panel1.Controls.Add(this.Summer);
            this.panel1.Location = new System.Drawing.Point(121, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 222);
            this.panel1.TabIndex = 10;
            // 
            // selectAll
            // 
            this.selectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.selectAll.Location = new System.Drawing.Point(48, 183);
            this.selectAll.Margin = new System.Windows.Forms.Padding(4);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(117, 28);
            this.selectAll.TabIndex = 7;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drives: ";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Home.Location = new System.Drawing.Point(28, 150);
            this.Home.Margin = new System.Windows.Forms.Padding(4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(78, 24);
            this.Home.TabIndex = 5;
            this.Home.Text = "Home ";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // MeetingMatrix
            // 
            this.MeetingMatrix.AutoSize = true;
            this.MeetingMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.MeetingMatrix.Location = new System.Drawing.Point(28, 94);
            this.MeetingMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.MeetingMatrix.Name = "MeetingMatrix";
            this.MeetingMatrix.Size = new System.Drawing.Size(134, 24);
            this.MeetingMatrix.TabIndex = 4;
            this.MeetingMatrix.Text = "Meeting Matrix";
            this.MeetingMatrix.UseVisualStyleBackColor = true;
            // 
            // RoomViewer
            // 
            this.RoomViewer.AutoSize = true;
            this.RoomViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RoomViewer.Location = new System.Drawing.Point(28, 122);
            this.RoomViewer.Margin = new System.Windows.Forms.Padding(4);
            this.RoomViewer.Name = "RoomViewer";
            this.RoomViewer.Size = new System.Drawing.Size(126, 24);
            this.RoomViewer.TabIndex = 3;
            this.RoomViewer.Text = "Room Viewer";
            this.RoomViewer.UseVisualStyleBackColor = true;
            // 
            // SCES
            // 
            this.SCES.AutoSize = true;
            this.SCES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.SCES.Location = new System.Drawing.Point(28, 65);
            this.SCES.Margin = new System.Windows.Forms.Padding(4);
            this.SCES.Name = "SCES";
            this.SCES.Size = new System.Drawing.Size(75, 24);
            this.SCES.TabIndex = 2;
            this.SCES.Text = "SCES";
            this.SCES.UseVisualStyleBackColor = true;
            // 
            // Summer
            // 
            this.Summer.AutoSize = true;
            this.Summer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Summer.Location = new System.Drawing.Point(28, 33);
            this.Summer.Margin = new System.Windows.Forms.Padding(4);
            this.Summer.Name = "Summer";
            this.Summer.Size = new System.Drawing.Size(91, 24);
            this.Summer.TabIndex = 1;
            this.Summer.Text = "Summer";
            this.Summer.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.loginPanel);
            this.Admin.Controls.Add(this.adminPanel);
            this.Admin.Location = new System.Drawing.Point(4, 27);
            this.Admin.Margin = new System.Windows.Forms.Padding(4);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(4);
            this.Admin.Size = new System.Drawing.Size(455, 422);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.adminPassword);
            this.loginPanel.Controls.Add(this.AdminPasswordLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(60, 9);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(356, 106);
            this.loginPanel.TabIndex = 9;
            // 
            // adminPassword
            // 
            this.adminPassword.AcceptsReturn = true;
            this.adminPassword.Location = new System.Drawing.Point(165, 21);
            this.adminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '*';
            this.adminPassword.Size = new System.Drawing.Size(132, 24);
            this.adminPassword.TabIndex = 1;
            this.adminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.AdminPasswordLabel.Location = new System.Drawing.Point(65, 25);
            this.AdminPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.AdminPasswordLabel.TabIndex = 4;
            this.AdminPasswordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(121, 54);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.adminUserNameLabel);
            this.adminPanel.Controls.Add(this.checkBox1);
            this.adminPanel.Controls.Add(this.button1);
            this.adminPanel.Controls.Add(this.adminLoginPasswordText);
            this.adminPanel.Controls.Add(this.driveLocationText);
            this.adminPanel.Controls.Add(this.DriveAddressLabel);
            this.adminPanel.Controls.Add(this.adminPasswordLoginLabel);
            this.adminPanel.Controls.Add(this.adminLoginUserNameText);
            this.adminPanel.Location = new System.Drawing.Point(59, 122);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(357, 289);
            this.adminPanel.TabIndex = 0;
            this.adminPanel.Visible = false;
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Location = new System.Drawing.Point(56, 79);
            this.adminUserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(81, 18);
            this.adminUserNameLabel.TabIndex = 8;
            this.adminUserNameLabel.Text = "Username:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 146);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Use Windows Credentials";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // adminLoginPasswordText
            // 
            this.adminLoginPasswordText.Location = new System.Drawing.Point(152, 108);
            this.adminLoginPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.adminLoginPasswordText.Name = "adminLoginPasswordText";
            this.adminLoginPasswordText.PasswordChar = '*';
            this.adminLoginPasswordText.Size = new System.Drawing.Size(132, 24);
            this.adminLoginPasswordText.TabIndex = 2;
            this.adminLoginPasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tab_KeyDown);
            // 
            // driveLocationText
            // 
            this.driveLocationText.Location = new System.Drawing.Point(20, 42);
            this.driveLocationText.Margin = new System.Windows.Forms.Padding(4);
            this.driveLocationText.Name = "driveLocationText";
            this.driveLocationText.Size = new System.Drawing.Size(320, 24);
            this.driveLocationText.TabIndex = 0;
            // 
            // DriveAddressLabel
            // 
            this.DriveAddressLabel.AutoSize = true;
            this.DriveAddressLabel.Location = new System.Drawing.Point(17, 18);
            this.DriveAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DriveAddressLabel.Name = "DriveAddressLabel";
            this.DriveAddressLabel.Size = new System.Drawing.Size(104, 18);
            this.DriveAddressLabel.TabIndex = 6;
            this.DriveAddressLabel.Text = "Drive Address:";
            // 
            // adminPasswordLoginLabel
            // 
            this.adminPasswordLoginLabel.AutoSize = true;
            this.adminPasswordLoginLabel.Location = new System.Drawing.Point(60, 112);
            this.adminPasswordLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminPasswordLoginLabel.Name = "adminPasswordLoginLabel";
            this.adminPasswordLoginLabel.Size = new System.Drawing.Size(79, 18);
            this.adminPasswordLoginLabel.TabIndex = 9;
            this.adminPasswordLoginLabel.Text = "Password:";
            // 
            // adminLoginUserNameText
            // 
            this.adminLoginUserNameText.Location = new System.Drawing.Point(152, 75);
            this.adminLoginUserNameText.Margin = new System.Windows.Forms.Padding(4);
            this.adminLoginUserNameText.Name = "adminLoginUserNameText";
            this.adminLoginUserNameText.Size = new System.Drawing.Size(132, 24);
            this.adminLoginUserNameText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 10;
            // 
            // statusBox
            // 
            this.statusBox.AcceptsReturn = true;
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.statusBox.Location = new System.Drawing.Point(20, 604);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusBox.Size = new System.Drawing.Size(456, 141);
            this.statusBox.TabIndex = 11;
            // 
            // DriveRemap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(493, 777);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriveRemap";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.CheckBox studentCheck;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Home;
        private System.Windows.Forms.CheckBox MeetingMatrix;
        private System.Windows.Forms.CheckBox RoomViewer;
        private System.Windows.Forms.CheckBox SCES;
        private System.Windows.Forms.CheckBox Summer;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DriveAddressLabel;
        private System.Windows.Forms.TextBox driveLocationText;
        private System.Windows.Forms.Panel adminPanel;
        private Panel loginPanel;
        private TextBox adminLoginPasswordText;
        private TextBox adminLoginUserNameText;
        private Label adminPasswordLoginLabel;
        private Label adminUserNameLabel;
        private CheckBox checkBox1;
        private TextBox statusBox;
    }
}


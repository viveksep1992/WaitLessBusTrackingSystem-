namespace WaitLess_Bus_Tracking_System
{
    partial class FrmMDIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDIMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnHIDE = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.PicBus = new System.Windows.Forms.PictureBox();
            this.PanelMENU = new System.Windows.Forms.Panel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.BtnBusReGistration = new System.Windows.Forms.Button();
            this.BtnNewUserCreation = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBusTrack = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnStudentSearch = new System.Windows.Forms.Button();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblLoginAS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDesign = new System.Windows.Forms.ToolStripStatusLabel();
            this.Designation = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picCllgeBus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBus)).BeginInit();
            this.PanelMENU.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCllgeBus)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BtnHIDE
            // 
            this.BtnHIDE.BackColor = System.Drawing.Color.Transparent;
            this.BtnHIDE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHIDE.BackgroundImage")));
            this.BtnHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHIDE.FlatAppearance.BorderSize = 0;
            this.BtnHIDE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnHIDE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHIDE.Image = ((System.Drawing.Image)(resources.GetObject("BtnHIDE.Image")));
            this.BtnHIDE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHIDE.Location = new System.Drawing.Point(521, -14);
            this.BtnHIDE.Name = "BtnHIDE";
            this.BtnHIDE.Size = new System.Drawing.Size(43, 43);
            this.BtnHIDE.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnHIDE, "Minimize/Hide");
            this.BtnHIDE.UseVisualStyleBackColor = false;
            this.BtnHIDE.Click += new System.EventHandler(this.BtnHIDE_Click);
            this.BtnHIDE.MouseLeave += new System.EventHandler(this.ShowBUS2);
            this.BtnHIDE.MouseHover += new System.EventHandler(this.ShowBUS1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(2, 81);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 60);
            this.btnMenu.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMenu, "Click here to go to Main Menu");
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            this.btnMenu.MouseLeave += new System.EventHandler(this.showIMG1);
            this.btnMenu.MouseHover += new System.EventHandler(this.ShowIMG);
            // 
            // PicBus
            // 
            this.PicBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBus.Image = ((System.Drawing.Image)(resources.GetObject("PicBus.Image")));
            this.PicBus.Location = new System.Drawing.Point(2, 81);
            this.PicBus.Name = "PicBus";
            this.PicBus.Size = new System.Drawing.Size(1367, 690);
            this.PicBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBus.TabIndex = 9;
            this.PicBus.TabStop = false;
            this.toolTip1.SetToolTip(this.PicBus, "Go to the Left Top Corner  PIN Button to Open Menu Control Panel");
            // 
            // PanelMENU
            // 
            this.PanelMENU.BackColor = System.Drawing.Color.Black;
            this.PanelMENU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMENU.BackgroundImage")));
            this.PanelMENU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMENU.Controls.Add(this.BtnAbout);
            this.PanelMENU.Controls.Add(this.btn_LogOut);
            this.PanelMENU.Controls.Add(this.BtnBusReGistration);
            this.PanelMENU.Controls.Add(this.BtnNewUserCreation);
            this.PanelMENU.Controls.Add(this.BtnExit);
            this.PanelMENU.Controls.Add(this.BtnBusTrack);
            this.PanelMENU.Controls.Add(this.BtnSettings);
            this.PanelMENU.Controls.Add(this.BtnStudentSearch);
            this.PanelMENU.Controls.Add(this.BtnRegistration);
            this.PanelMENU.Location = new System.Drawing.Point(454, 129);
            this.PanelMENU.Name = "PanelMENU";
            this.PanelMENU.Size = new System.Drawing.Size(462, 514);
            this.PanelMENU.TabIndex = 15;
            this.toolTip1.SetToolTip(this.PanelMENU, "Main Menu");
            this.PanelMENU.Visible = false;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAbout.Location = new System.Drawing.Point(156, 7);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(141, 165);
            this.BtnAbout.TabIndex = 18;
            this.BtnAbout.Text = "About Software && Programmer";
            this.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnAbout, "Student Registration");
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_LogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(190, 371);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(79, 84);
            this.btn_LogOut.TabIndex = 17;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_LogOut, "Log Out");
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click_1);
            // 
            // BtnBusReGistration
            // 
            this.BtnBusReGistration.BackColor = System.Drawing.Color.Transparent;
            this.BtnBusReGistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusReGistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBusReGistration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBusReGistration.FlatAppearance.BorderSize = 0;
            this.BtnBusReGistration.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnBusReGistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnBusReGistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnBusReGistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusReGistration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusReGistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBusReGistration.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusReGistration.Image")));
            this.BtnBusReGistration.Location = new System.Drawing.Point(297, 343);
            this.BtnBusReGistration.Name = "BtnBusReGistration";
            this.BtnBusReGistration.Size = new System.Drawing.Size(140, 140);
            this.BtnBusReGistration.TabIndex = 16;
            this.BtnBusReGistration.Text = "Student Bus Registration";
            this.BtnBusReGistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnBusReGistration, "Bus Registration");
            this.BtnBusReGistration.UseVisualStyleBackColor = false;
            this.BtnBusReGistration.Click += new System.EventHandler(this.BtnBusReGistration_Click);
            // 
            // BtnNewUserCreation
            // 
            this.BtnNewUserCreation.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewUserCreation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNewUserCreation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewUserCreation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNewUserCreation.FlatAppearance.BorderSize = 0;
            this.BtnNewUserCreation.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnNewUserCreation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnNewUserCreation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnNewUserCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewUserCreation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewUserCreation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewUserCreation.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewUserCreation.Image")));
            this.BtnNewUserCreation.Location = new System.Drawing.Point(303, 189);
            this.BtnNewUserCreation.Name = "BtnNewUserCreation";
            this.BtnNewUserCreation.Size = new System.Drawing.Size(129, 140);
            this.BtnNewUserCreation.TabIndex = 15;
            this.BtnNewUserCreation.Text = "User Management";
            this.BtnNewUserCreation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnNewUserCreation, "User Management");
            this.BtnNewUserCreation.UseVisualStyleBackColor = false;
            this.BtnNewUserCreation.Visible = false;
            this.BtnNewUserCreation.Click += new System.EventHandler(this.BtnNewUserCreation_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(169, 174);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(128, 177);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "Application Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnExit, "Application Exit");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBusTrack
            // 
            this.BtnBusTrack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBusTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBusTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBusTrack.FlatAppearance.BorderSize = 0;
            this.BtnBusTrack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnBusTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnBusTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnBusTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusTrack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBusTrack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusTrack.Image")));
            this.BtnBusTrack.Location = new System.Drawing.Point(21, 339);
            this.BtnBusTrack.Name = "BtnBusTrack";
            this.BtnBusTrack.Size = new System.Drawing.Size(129, 124);
            this.BtnBusTrack.TabIndex = 13;
            this.BtnBusTrack.Text = "Bus Track";
            this.BtnBusTrack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnBusTrack, "Bus Track");
            this.BtnBusTrack.UseVisualStyleBackColor = false;
            this.BtnBusTrack.Click += new System.EventHandler(this.BtnBusTrack_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
            this.BtnSettings.Location = new System.Drawing.Point(303, 39);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(129, 140);
            this.BtnSettings.TabIndex = 12;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnSettings, "Settings");
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnStudentSearch
            // 
            this.BtnStudentSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudentSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStudentSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStudentSearch.FlatAppearance.BorderSize = 0;
            this.BtnStudentSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnStudentSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnStudentSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnStudentSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStudentSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnStudentSearch.Image")));
            this.BtnStudentSearch.Location = new System.Drawing.Point(21, 200);
            this.BtnStudentSearch.Name = "BtnStudentSearch";
            this.BtnStudentSearch.Size = new System.Drawing.Size(129, 124);
            this.BtnStudentSearch.TabIndex = 11;
            this.BtnStudentSearch.Text = "Student Search";
            this.BtnStudentSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnStudentSearch, "Student Search");
            this.BtnStudentSearch.UseVisualStyleBackColor = false;
            this.BtnStudentSearch.Click += new System.EventHandler(this.BtnStudentSearch_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRegistration.FlatAppearance.BorderSize = 0;
            this.BtnRegistration.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistration.Image")));
            this.BtnRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegistration.Location = new System.Drawing.Point(21, 39);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(129, 124);
            this.BtnRegistration.TabIndex = 10;
            this.BtnRegistration.Text = "Student Registration";
            this.BtnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnRegistration, "Student Registration");
            this.BtnRegistration.UseVisualStyleBackColor = false;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "WaitLess Bus Tracking System";
            this.notifyIcon1.Text = "WaitLess Bus Tracking System";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip.BackgroundImage")));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoginAS,
            this.lblUser,
            this.UserName,
            this.lblDesign,
            this.Designation,
            this.lblLTime,
            this.LoginTime,
            this.lblDate,
            this.TDate,
            this.lblTime,
            this.tTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 745);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1370, 27);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblLoginAS
            // 
            this.lblLoginAS.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginAS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAS.ForeColor = System.Drawing.Color.Lime;
            this.lblLoginAS.Name = "lblLoginAS";
            this.lblLoginAS.Size = new System.Drawing.Size(112, 22);
            this.lblLoginAS.Text = "Logged IN As :";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Lime;
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(104, 22);
            this.lblUser.Text = "UserName:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = false;
            this.UserName.AutoToolTip = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserName.BackgroundImage")));
            this.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.UserName.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.UserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UserName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(200, 22);
            this.UserName.ToolTipText = "Current User";
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblDesign.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.Lime;
            this.lblDesign.Image = ((System.Drawing.Image)(resources.GetObject("lblDesign.Image")));
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(111, 22);
            this.lblDesign.Text = "Designation:";
            // 
            // Designation
            // 
            this.Designation.AutoSize = false;
            this.Designation.AutoToolTip = true;
            this.Designation.BackColor = System.Drawing.Color.Transparent;
            this.Designation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Designation.BackgroundImage")));
            this.Designation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Designation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Designation.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.Designation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Designation.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.ForeColor = System.Drawing.Color.Black;
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(226, 22);
            this.Designation.Spring = true;
            this.Designation.ToolTipText = "Designation";
            // 
            // lblLTime
            // 
            this.lblLTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTime.ForeColor = System.Drawing.Color.Lime;
            this.lblLTime.Image = ((System.Drawing.Image)(resources.GetObject("lblLTime.Image")));
            this.lblLTime.Name = "lblLTime";
            this.lblLTime.Size = new System.Drawing.Size(113, 22);
            this.lblLTime.Text = "Log In Time:";
            // 
            // LoginTime
            // 
            this.LoginTime.AutoSize = false;
            this.LoginTime.AutoToolTip = true;
            this.LoginTime.BackColor = System.Drawing.Color.Transparent;
            this.LoginTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginTime.BackgroundImage")));
            this.LoginTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LoginTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.LoginTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoginTime.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTime.ForeColor = System.Drawing.Color.Black;
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.Size = new System.Drawing.Size(121, 22);
            this.LoginTime.ToolTipText = "Log In Time";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Image = ((System.Drawing.Image)(resources.GetObject("lblDate.Image")));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 22);
            this.lblDate.Text = "Date:";
            // 
            // TDate
            // 
            this.TDate.AutoSize = false;
            this.TDate.AutoToolTip = true;
            this.TDate.BackColor = System.Drawing.Color.Transparent;
            this.TDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TDate.BackgroundImage")));
            this.TDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TDate.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.TDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TDate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDate.ForeColor = System.Drawing.Color.Black;
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(121, 22);
            this.TDate.ToolTipText = "Date";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Image = ((System.Drawing.Image)(resources.GetObject("lblTime.Image")));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 22);
            this.lblTime.Text = "Time:";
            // 
            // tTime
            // 
            this.tTime.AutoSize = false;
            this.tTime.AutoToolTip = true;
            this.tTime.BackColor = System.Drawing.Color.Transparent;
            this.tTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tTime.BackgroundImage")));
            this.tTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.tTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tTime.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTime.ForeColor = System.Drawing.Color.Black;
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(121, 22);
            this.tTime.ToolTipText = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picCllgeBus
            // 
            this.picCllgeBus.BackColor = System.Drawing.Color.Transparent;
            this.picCllgeBus.Image = ((System.Drawing.Image)(resources.GetObject("picCllgeBus.Image")));
            this.picCllgeBus.Location = new System.Drawing.Point(346, 234);
            this.picCllgeBus.Name = "picCllgeBus";
            this.picCllgeBus.Size = new System.Drawing.Size(681, 376);
            this.picCllgeBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCllgeBus.TabIndex = 14;
            this.picCllgeBus.TabStop = false;
            // 
            // FrmMDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.PanelMENU);
            this.Controls.Add(this.picCllgeBus);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.PicBus);
            this.Controls.Add(this.BtnHIDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMDIMain";
            this.Text = "FrmMDIMain";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMDIMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBus)).EndInit();
            this.PanelMENU.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCllgeBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button BtnHIDE;
        private System.Windows.Forms.PictureBox PicBus;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginAS;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        public System.Windows.Forms.ToolStripStatusLabel UserName;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblDesign;
        public System.Windows.Forms.ToolStripStatusLabel Designation;
        private System.Windows.Forms.ToolStripStatusLabel lblLTime;
        private System.Windows.Forms.ToolStripStatusLabel LoginTime;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel TDate;
        private System.Windows.Forms.ToolStripStatusLabel tTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picCllgeBus;
        public System.Windows.Forms.Panel PanelMENU;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button BtnBusReGistration;
        public System.Windows.Forms.Button BtnNewUserCreation;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBusTrack;
        public System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnStudentSearch;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.Button BtnAbout;


    }
}
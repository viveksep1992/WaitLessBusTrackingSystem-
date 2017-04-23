namespace WaitLess_Bus_Tracking_System
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblClose = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PicLOGO = new System.Windows.Forms.PictureBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClose
            // 
            this.LblClose.BackColor = System.Drawing.Color.Transparent;
            this.LblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblClose.Image = ((System.Drawing.Image)(resources.GetObject("LblClose.Image")));
            this.LblClose.Location = new System.Drawing.Point(630, -6);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(29, 32);
            this.LblClose.TabIndex = 4;
            this.LblClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.LblClose, "Close\r\n");
            this.LblClose.Click += new System.EventHandler(this.label5_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(439, 376);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(70, 27);
            this.BtnLogin.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnLogin, "Click Here to Login");
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PicLOGO
            // 
            this.PicLOGO.BackColor = System.Drawing.Color.Transparent;
            this.PicLOGO.Image = ((System.Drawing.Image)(resources.GetObject("PicLOGO.Image")));
            this.PicLOGO.Location = new System.Drawing.Point(190, -13);
            this.PicLOGO.Name = "PicLOGO";
            this.PicLOGO.Size = new System.Drawing.Size(300, 258);
            this.PicLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLOGO.TabIndex = 3;
            this.PicLOGO.TabStop = false;
            this.toolTip1.SetToolTip(this.PicLOGO, "Omkarananda Institute Of Management & Technology");
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserName.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUserName.Location = new System.Drawing.Point(294, 263);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(193, 21);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Text = "User Name";
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtUserName, "Enter User Name");
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.Location = new System.Drawing.Point(294, 317);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(193, 21);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Password";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtPassword, "Enter Password");
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            // 
            // UserType
            // 
            this.UserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserType.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.ForeColor = System.Drawing.Color.Black;
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Accounts Officer",
            "Administrator",
            "Admissions Officer",
            "Class Cordinator",
            "Lecturer"});
            this.UserType.Location = new System.Drawing.Point(285, 218);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(208, 27);
            this.UserType.Sorted = true;
            this.UserType.TabIndex = 0;
            this.UserType.Text = "User Type";
            this.toolTip1.SetToolTip(this.UserType, "Choose User Type");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(271, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(273, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(666, 504);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.PicLOGO);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.toolTip1.SetToolTip(this, "Login Form");
            ((System.ComponentModel.ISupportInitialize)(this.PicLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PicLOGO;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
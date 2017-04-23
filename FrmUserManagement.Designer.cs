namespace WaitLess_Bus_Tracking_System
{
    partial class FrmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManagement));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpUserDetails = new System.Windows.Forms.GroupBox();
            this.mTxtContactNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtEMail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmbUserType = new System.Windows.Forms.ComboBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(101, 13);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(82, 31);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailability.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAvailability.Location = new System.Drawing.Point(312, 31);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(121, 27);
            this.btnCheckAvailability.TabIndex = 6;
            this.btnCheckAvailability.Text = "Check Availabilty";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(189, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "User Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.Location = new System.Drawing.Point(277, 13);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate_record.TabIndex = 10;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetails.Location = new System.Drawing.Point(365, 13);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetDetails.Size = new System.Drawing.Size(82, 31);
            this.btnGetDetails.TabIndex = 11;
            this.btnGetDetails.Text = "U&ser Data";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.Location = new System.Drawing.Point(13, 13);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(82, 31);
            this.btnNewRecord.TabIndex = 7;
            this.btnNewRecord.Text = "&New";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.btnGetDetails);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Location = new System.Drawing.Point(48, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 61);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contact No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // gpUserDetails
            // 
            this.gpUserDetails.BackColor = System.Drawing.Color.Transparent;
            this.gpUserDetails.Controls.Add(this.mTxtContactNo);
            this.gpUserDetails.Controls.Add(this.TxtEMail);
            this.gpUserDetails.Controls.Add(this.TxtName);
            this.gpUserDetails.Controls.Add(this.TxtPassword);
            this.gpUserDetails.Controls.Add(this.CmbUserType);
            this.gpUserDetails.Controls.Add(this.TxtUserName);
            this.gpUserDetails.Controls.Add(this.label7);
            this.gpUserDetails.Controls.Add(this.btnCheckAvailability);
            this.gpUserDetails.Controls.Add(this.label6);
            this.gpUserDetails.Controls.Add(this.label5);
            this.gpUserDetails.Controls.Add(this.label4);
            this.gpUserDetails.Controls.Add(this.label3);
            this.gpUserDetails.Controls.Add(this.label2);
            this.gpUserDetails.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpUserDetails.ForeColor = System.Drawing.Color.White;
            this.gpUserDetails.Location = new System.Drawing.Point(49, 93);
            this.gpUserDetails.Name = "gpUserDetails";
            this.gpUserDetails.Size = new System.Drawing.Size(464, 258);
            this.gpUserDetails.TabIndex = 58;
            this.gpUserDetails.TabStop = false;
            this.gpUserDetails.Text = "User Details";
            // 
            // mTxtContactNo
            // 
            this.mTxtContactNo.Location = new System.Drawing.Point(125, 181);
            this.mTxtContactNo.Mask = "(+99)-0000000000";
            this.mTxtContactNo.Name = "mTxtContactNo";
            this.mTxtContactNo.Size = new System.Drawing.Size(172, 29);
            this.mTxtContactNo.TabIndex = 4;
            this.mTxtContactNo.Text = "91";
            // 
            // TxtEMail
            // 
            this.TxtEMail.Location = new System.Drawing.Point(125, 216);
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(246, 29);
            this.TxtEMail.TabIndex = 5;
            this.TxtEMail.Validating += new System.ComponentModel.CancelEventHandler(this.EMail_Validating);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(125, 141);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(246, 29);
            this.TxtName.TabIndex = 3;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Of_User_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(125, 106);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(172, 29);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // CmbUserType
            // 
            this.CmbUserType.FormattingEnabled = true;
            this.CmbUserType.Items.AddRange(new object[] {
            "Administrator",
            "Admissions Officer",
            "Accounts Officer",
            "Lecturer",
            "Class Cordinator"});
            this.CmbUserType.Location = new System.Drawing.Point(125, 70);
            this.CmbUserType.Name = "CmbUserType";
            this.CmbUserType.Size = new System.Drawing.Size(172, 30);
            this.CmbUserType.TabIndex = 1;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(125, 32);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(172, 29);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.UserName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(-2, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(584, 63);
            this.label8.TabIndex = 60;
            this.label8.Text = "User Management";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(523, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 60);
            this.btn_Close.TabIndex = 61;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 463);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpUserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Manegement";
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.gpUserDetails.ResumeLayout(false);
            this.gpUserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate_record;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpUserDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CmbUserType;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.MaskedTextBox mTxtContactNo;
        private System.Windows.Forms.TextBox TxtEMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Close;

    }
}
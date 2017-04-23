namespace WaitLess_Bus_Tracking_System
{
    partial class FrmRegisteredUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisteredUserDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dGVUserDetails = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btnLoginDetails = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UserType);
            this.groupBox1.Location = new System.Drawing.Point(4, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 43);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "User Type";
            // 
            // UserType
            // 
            this.UserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserType.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Administrator",
            "Admissions Officer",
            "Accounts Officer",
            "Lecturer",
            "Class Cordinator"});
            this.UserType.Location = new System.Drawing.Point(114, 11);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(172, 26);
            this.UserType.TabIndex = 20;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.UserType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(-3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(800, 63);
            this.label8.TabIndex = 61;
            this.label8.Text = "Registered Users Details";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dGVUserDetails
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Lime;
            this.dGVUserDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVUserDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGVUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUserDetails.DefaultCellStyle = dataGridViewCellStyle9;
            this.dGVUserDetails.EnableHeadersVisualStyles = false;
            this.dGVUserDetails.Location = new System.Drawing.Point(0, 104);
            this.dGVUserDetails.Name = "dGVUserDetails";
            this.dGVUserDetails.Size = new System.Drawing.Size(797, 335);
            this.dGVUserDetails.TabIndex = 62;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(744, 63);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(54, 40);
            this.btn_Back.TabIndex = 62;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btnLoginDetails
            // 
            this.btnLoginDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDetails.Location = new System.Drawing.Point(603, 68);
            this.btnLoginDetails.Name = "btnLoginDetails";
            this.btnLoginDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoginDetails.Size = new System.Drawing.Size(124, 31);
            this.btnLoginDetails.TabIndex = 63;
            this.btnLoginDetails.Text = "Users &Login Details";
            this.btnLoginDetails.UseVisualStyleBackColor = true;
            this.btnLoginDetails.Click += new System.EventHandler(this.btnLoginDetails_Click);
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
            this.btn_Close.Location = new System.Drawing.Point(752, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 62);
            this.btn_Close.TabIndex = 64;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FrmRegisteredUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 466);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btnLoginDetails);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dGVUserDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegisteredUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegisteredUserDetails";
            this.Load += new System.EventHandler(this.FrmRegisteredUserDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dGVUserDetails;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btnLoginDetails;
        private System.Windows.Forms.Button btn_Close;
    }
}
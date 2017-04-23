namespace WaitLess_Bus_Tracking_System
{
    partial class FrmLoginDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginDetails));
            this.dGVLoginDetails = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dDated = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoginDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVLoginDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.dGVLoginDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVLoginDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVLoginDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVLoginDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVLoginDetails.EnableHeadersVisualStyles = false;
            this.dGVLoginDetails.Location = new System.Drawing.Point(0, 110);
            this.dGVLoginDetails.Name = "dGVLoginDetails";
            this.dGVLoginDetails.Size = new System.Drawing.Size(657, 448);
            this.dGVLoginDetails.TabIndex = 63;
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
            this.btn_Back.Location = new System.Drawing.Point(595, 65);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(61, 43);
            this.btn_Back.TabIndex = 64;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UserType);
            this.groupBox1.Location = new System.Drawing.Point(4, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 44);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "By User Name";
            // 
            // UserType
            // 
            this.UserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserType.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Location = new System.Drawing.Point(117, 11);
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
            this.label8.Location = new System.Drawing.Point(0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(657, 63);
            this.label8.TabIndex = 66;
            this.label8.Text = "Users Login Details";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dDated);
            this.groupBox2.Location = new System.Drawing.Point(302, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 43);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "By Date";
            // 
            // dDated
            // 
            this.dDated.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dDated.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dDated.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDated.FormattingEnabled = true;
            this.dDated.Location = new System.Drawing.Point(72, 11);
            this.dDated.Name = "dDated";
            this.dDated.Size = new System.Drawing.Size(130, 26);
            this.dDated.TabIndex = 20;
            this.dDated.SelectedIndexChanged += new System.EventHandler(this.dDated_SelectedIndexChanged);
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
            this.btn_Close.Location = new System.Drawing.Point(610, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 64);
            this.btn_Close.TabIndex = 67;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.BackColor = System.Drawing.Color.Transparent;
            this.LblCount.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.ForeColor = System.Drawing.Color.Black;
            this.LblCount.Location = new System.Drawing.Point(204, 568);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(50, 21);
            this.LblCount.TabIndex = 68;
            this.LblCount.Text = "Total:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(510, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 33);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmLoginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 592);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dGVLoginDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginDetails";
            this.Load += new System.EventHandler(this.FrmLoginDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoginDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVLoginDetails;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox dDated;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDelete;
    }
}
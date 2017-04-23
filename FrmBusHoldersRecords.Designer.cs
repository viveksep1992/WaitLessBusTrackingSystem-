namespace WaitLess_Bus_Tracking_System
{
    partial class FrmBusHoldersRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusHoldersRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBstop = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBno = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSID = new System.Windows.Forms.ComboBox();
            this.dGVBusHolders = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusHolders)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Close.Location = new System.Drawing.Point(1304, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 62);
            this.btn_Close.TabIndex = 68;
            this.toolTip1.SetToolTip(this.btn_Close, "Close");
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(0, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1348, 63);
            this.label8.TabIndex = 67;
            this.label8.Text = "Bus Holder Records";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Location = new System.Drawing.Point(333, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 44);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "By Course Name");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "By Course Name:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCourse.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(139, 11);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(108, 26);
            this.cmbCourse.TabIndex = 20;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbBstop);
            this.groupBox2.Location = new System.Drawing.Point(597, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 44);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, "By Student\'s Bus Stop");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "By BUS Stop:";
            // 
            // cmbBstop
            // 
            this.cmbBstop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBstop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBstop.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBstop.FormattingEnabled = true;
            this.cmbBstop.Location = new System.Drawing.Point(103, 11);
            this.cmbBstop.Name = "cmbBstop";
            this.cmbBstop.Size = new System.Drawing.Size(284, 26);
            this.cmbBstop.TabIndex = 20;
            this.cmbBstop.SelectedIndexChanged += new System.EventHandler(this.cmbBstop_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbBno);
            this.groupBox3.Location = new System.Drawing.Point(995, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 44);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, "By Bus No/ID");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "By Bus Number:";
            // 
            // cmbBno
            // 
            this.cmbBno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBno.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBno.FormattingEnabled = true;
            this.cmbBno.Location = new System.Drawing.Point(147, 11);
            this.cmbBno.Name = "cmbBno";
            this.cmbBno.Size = new System.Drawing.Size(77, 26);
            this.cmbBno.TabIndex = 20;
            this.cmbBno.SelectedIndexChanged += new System.EventHandler(this.cmbBno_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbSID);
            this.groupBox4.Location = new System.Drawing.Point(64, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 44);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, "By Student ID");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "By Student ID:";
            // 
            // cmbSID
            // 
            this.cmbSID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSID.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSID.FormattingEnabled = true;
            this.cmbSID.Location = new System.Drawing.Point(139, 11);
            this.cmbSID.Name = "cmbSID";
            this.cmbSID.Size = new System.Drawing.Size(108, 26);
            this.cmbSID.TabIndex = 20;
            this.cmbSID.SelectedIndexChanged += new System.EventHandler(this.cmbSID_SelectedIndexChanged);
            // 
            // dGVBusHolders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.dGVBusHolders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVBusHolders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVBusHolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVBusHolders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVBusHolders.EnableHeadersVisualStyles = false;
            this.dGVBusHolders.Location = new System.Drawing.Point(0, 118);
            this.dGVBusHolders.Name = "dGVBusHolders";
            this.dGVBusHolders.ReadOnly = true;
            this.dGVBusHolders.Size = new System.Drawing.Size(1350, 491);
            this.dGVBusHolders.TabIndex = 72;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(1228, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(76, 63);
            this.btn_Back.TabIndex = 73;
            this.toolTip1.SetToolTip(this.btn_Back, "Back");
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // FrmBusHoldersRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 644);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dGVBusHolders);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusHoldersRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusHoldersRecords";
            this.Load += new System.EventHandler(this.FrmBusHoldersRecords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusHolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbBstop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbBno;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbSID;
        private System.Windows.Forms.DataGridView dGVBusHolders;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
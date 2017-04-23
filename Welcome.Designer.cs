namespace WaitLess_Bus_Tracking_System
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PICwelcome = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LBLcomplete = new System.Windows.Forms.Label();
            this.LBLint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PICwelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // PICwelcome
            // 
            this.PICwelcome.BackColor = System.Drawing.Color.Yellow;
            this.PICwelcome.Image = ((System.Drawing.Image)(resources.GetObject("PICwelcome.Image")));
            this.PICwelcome.Location = new System.Drawing.Point(0, -1);
            this.PICwelcome.Name = "PICwelcome";
            this.PICwelcome.Size = new System.Drawing.Size(751, 374);
            this.PICwelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICwelcome.TabIndex = 15;
            this.PICwelcome.TabStop = false;
            this.toolTip1.SetToolTip(this.PICwelcome, "WaitLess Bus Tracking System");
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(725, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(20, 15);
            this.BtnClose.TabIndex = 25;
            this.toolTip1.SetToolTip(this.BtnClose, "Close");
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseLeave += new System.EventHandler(this.ShowIMG);
            this.BtnClose.MouseHover += new System.EventHandler(this.ShowImg);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(870, 7);
            this.progressBar1.TabIndex = 20;
            // 
            // LBLcomplete
            // 
            this.LBLcomplete.AutoSize = true;
            this.LBLcomplete.BackColor = System.Drawing.Color.Gold;
            this.LBLcomplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBLcomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcomplete.ForeColor = System.Drawing.Color.DarkRed;
            this.LBLcomplete.Image = ((System.Drawing.Image)(resources.GetObject("LBLcomplete.Image")));
            this.LBLcomplete.Location = new System.Drawing.Point(308, 340);
            this.LBLcomplete.Name = "LBLcomplete";
            this.LBLcomplete.Size = new System.Drawing.Size(52, 18);
            this.LBLcomplete.TabIndex = 24;
            this.LBLcomplete.Text = "label1";
            // 
            // LBLint
            // 
            this.LBLint.AutoSize = true;
            this.LBLint.BackColor = System.Drawing.Color.Gold;
            this.LBLint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLint.ForeColor = System.Drawing.Color.DarkRed;
            this.LBLint.Image = ((System.Drawing.Image)(resources.GetObject("LBLint.Image")));
            this.LBLint.Location = new System.Drawing.Point(411, 70);
            this.LBLint.Name = "LBLint";
            this.LBLint.Size = new System.Drawing.Size(52, 18);
            this.LBLint.TabIndex = 23;
            this.LBLint.Text = "label1";
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(750, 367);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LBLcomplete);
            this.Controls.Add(this.LBLint);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PICwelcome);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.toolTip1.SetToolTip(this, "WaitLess Bus Tracking System");
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICwelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PICwelcome;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LBLcomplete;
        private System.Windows.Forms.Label LBLint;
        private System.Windows.Forms.Button BtnClose;
    }
}


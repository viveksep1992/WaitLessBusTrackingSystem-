namespace WaitLess_Bus_Tracking_System
{
    partial class FrmBusTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusTrack));
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.picIMAGE = new System.Windows.Forms.PictureBox();
            this.LblRegistration = new System.Windows.Forms.Label();
            this.LblNameAdd = new System.Windows.Forms.Label();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WaitLess_Bus_Tracking_System.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.picIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameAdd.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameAdd.Location = new System.Drawing.Point(109, 616);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(207, 36);
            this.txtNameAdd.TabIndex = 59;
            this.txtNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameAdd.TextChanged += new System.EventHandler(this.txtNameAdd_TextChanged);
            this.txtNameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFName.Location = new System.Drawing.Point(6, 620);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(99, 28);
            this.lblFName.TabIndex = 60;
            this.lblFName.Text = "Bus No:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Indigo;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(254, 616);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(62, 37);
            this.Search.TabIndex = 61;
            this.Search.Text = "Go";
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // picIMAGE
            // 
            this.picIMAGE.BackColor = System.Drawing.Color.Transparent;
            this.picIMAGE.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picIMAGE.ErrorImage")));
            this.picIMAGE.Image = ((System.Drawing.Image)(resources.GetObject("picIMAGE.Image")));
            this.picIMAGE.Location = new System.Drawing.Point(-1, 61);
            this.picIMAGE.Name = "picIMAGE";
            this.picIMAGE.Size = new System.Drawing.Size(145, 161);
            this.picIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIMAGE.TabIndex = 63;
            this.picIMAGE.TabStop = false;
            // 
            // LblRegistration
            // 
            this.LblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.LblRegistration.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRegistration.Image = ((System.Drawing.Image)(resources.GetObject("LblRegistration.Image")));
            this.LblRegistration.Location = new System.Drawing.Point(24, 0);
            this.LblRegistration.Name = "LblRegistration";
            this.LblRegistration.Size = new System.Drawing.Size(1345, 61);
            this.LblRegistration.TabIndex = 69;
            this.LblRegistration.Text = "    Bus Search";
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNameAdd.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameAdd.ForeColor = System.Drawing.Color.Lime;
            this.LblNameAdd.Location = new System.Drawing.Point(143, 61);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(1225, 36);
            this.LblNameAdd.TabIndex = 70;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.AutoSize = true;
            this.btnCLOSE.BackColor = System.Drawing.Color.Transparent;
            this.btnCLOSE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLOSE.BackgroundImage")));
            this.btnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLOSE.FlatAppearance.BorderSize = 0;
            this.btnCLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLOSE.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOSE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLOSE.Image = ((System.Drawing.Image)(resources.GetObject("btnCLOSE.Image")));
            this.btnCLOSE.Location = new System.Drawing.Point(1258, 1);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(103, 59);
            this.btnCLOSE.TabIndex = 90;
            this.btnCLOSE.Text = "Close";
            this.btnCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCLOSE.UseVisualStyleBackColor = false;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            this.btnCLOSE.MouseLeave += new System.EventHandler(this.HideImg);
            this.btnCLOSE.MouseHover += new System.EventHandler(this.ShowImg);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 91;
            this.label1.Text = "Name";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 61);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1360, 600);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // FrmBusTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.LblNameAdd);
            this.Controls.Add(this.LblRegistration);
            this.Controls.Add(this.picIMAGE);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.elementHost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusTrack";
            this.Text = "FrmBusTrack";
            this.Load += new System.EventHandler(this.FrmBusTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private UserControl1 userControl11;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox picIMAGE;
        private System.Windows.Forms.Label LblRegistration;
        private System.Windows.Forms.Label LblNameAdd;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Label label1;

    }
}
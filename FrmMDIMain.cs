using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmMDIMain : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        
        public FrmMDIMain()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database.accdb");
            con.Open();
        }

        private void FrmMDIMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            TDate.Text = DateTime.Today.Date.ToShortDateString();
            LoginTime.Text = DateTime.Now.ToLongTimeString();
                     
        }
      
        private void ShowIMG(object sender, EventArgs e)
        {
            btnMenu.Image = Image.FromFile("Images/PIN2.png");
        }

        private void showIMG1(object sender, EventArgs e)
        {
            btnMenu.Image = Image.FromFile("Images/PIN1.png");
        }

       
        private void BtnHIDE_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon("Images/BUS1.ICO");
            notifyIcon1.BalloonTipText = "WaitLess Bus Tracking System";
            notifyIcon1.ShowBalloonTip(5000);
            this.Visible = false;
            notifyIcon1.Visible = true;   
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;   
        }


        private void ShowBUS1(object sender, EventArgs e)
        {
            BtnHIDE.Image = Image.FromFile("Images/B1.Png");
        }

        private void ShowBUS2(object sender, EventArgs e)
        {
            BtnHIDE.Image = Image.FromFile("Images/B2.Png");
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            PanelMENU.Visible = !PanelMENU.Visible;
            PicBus.Visible = !PicBus.Visible;
            picCllgeBus.Visible = !picCllgeBus.Visible;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tTime.Text = DateTime.Now.ToLongTimeString();
        }

     

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration f = new FrmRegistration();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void BtnStudentSearch_Click(object sender, EventArgs e)
        {
            FrmStudentSearch f = new FrmStudentSearch();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void BtnBusTrack_Click(object sender, EventArgs e)
        {
            FrmBusTrack f = new FrmBusTrack();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings f = new FrmSettings();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void BtnNewUserCreation_Click(object sender, EventArgs e)
        {
            FrmUserManagement f = new FrmUserManagement();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void BtnBusReGistration_Click(object sender, EventArgs e)
        {
            FrmStudentBusRegistration f = new FrmStudentBusRegistration();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            cmd = new OleDbCommand("INSERT INTO Login_Details VALUES(@UserName,@Designation,@LoginTime,@loginDate,@logOutTime)", con);
            try
            {
                cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                cmd.Parameters.AddWithValue("@Designation", Designation.Text);
                cmd.Parameters.AddWithValue("@LoginTime", LoginTime.Text);
                cmd.Parameters.AddWithValue("@loginDate", TDate.Text);
                cmd.Parameters.AddWithValue("@logOutTime", tTime.Text);

                if (MessageBox.Show("Do you Really want to LogOut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("INSERT INTO Login_Details VALUES(@UserName,@Designation,@LoginTime,@loginDate,@logOutTime)", con);
            try
            {
                cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                cmd.Parameters.AddWithValue("@Designation", Designation.Text);
                cmd.Parameters.AddWithValue("@LoginTime", LoginTime.Text);
                cmd.Parameters.AddWithValue("@loginDate", TDate.Text);
                cmd.Parameters.AddWithValue("@logOutTime", tTime.Text);

                if (MessageBox.Show("Do you Really want to Quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.MdiParent = this;
            PanelMENU.Visible = false;
            PicBus.Visible = false;
            picCllgeBus.Visible = false;
            f.Show();

        }

       
    }
}

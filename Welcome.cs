using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar1 .Value = progressBar1 .Value + 1;
        LBLcomplete.Text = progressBar1.Value + "% Completed";

        switch (progressBar1 .Value )
        {
            case 2:
                LBLint.Text = "Initializing.";
                break ;
            case 4:
                LBLint.Text = "Initializing..";
                break;
            case 8:
                LBLint.Text = "Initializing...";
                break;
            case 12:
                LBLint.Text = "Initializing....";
                break;
            case 14:
                LBLint.Text = "Initializing.....";
                break;
            case 18:
                LBLint.Text = "Initializing......";
                break;
            case 20:
                LBLint.Text = "Loading All Forms";
                break;
            case 30:
                LBLint.Text = "Generating Main Menu";
                break;
            case 40:
                LBLint.Text = "Analizing Data Memory";
                break;
            case 60:
                LBLint.Text = "Preparing Student List";
                break;
            case 80:
                LBLint.Text = "Finalizing the System";
                break;
            case 100:
                LBLint.Text = "Please Wait...";
                this.Hide();
            FrmLogin f = new FrmLogin();
            f.Visible   = true;
            timer1.Enabled = false;
            break;
            }
            
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            LBLcomplete.Text = "0 % Complete";
        }

        private void ShowImg(object sender, EventArgs e)
        {
            BtnClose.Image = Image.FromFile("Images/Close.png");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowIMG(object sender, EventArgs e)
        {
             BtnClose.Image = Image.FromFile("Images/Close1.png");
        }
        

     
    }
}

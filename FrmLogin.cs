using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmLogin : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
       
        public FrmLogin()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=Database.accdb");
            con.Open();                    
        }
     
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (UserType.Text == "")
            {
                MessageBox.Show("Please Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserType.Focus();
                return;
            }
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            if (TxtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            cmd = new OleDbCommand("SELECT * FROM Login WHERE UserName LIKE @UserName And Password LIKE @Password And UserType LIKE @UserType", con);
            cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@UserType", UserType.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmMDIMain f = new FrmMDIMain();
                f.UserName.Text = this.TxtUserName.Text.ToUpper();
                f.Designation.Text = this.UserType.Text.ToUpper();
                if (UserType.Text == "Administrator")
                {
                    f.BtnNewUserCreation.Visible = true;
                }
                this.Hide();
                f.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Clear();
                TxtPassword.Clear();
                TxtUserName.Focus();
            }
        }      
        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            TxtUserName.Clear();
            TxtUserName.ForeColor = Color.Black;
        }     
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.UseSystemPasswordChar = true;
        }     
    }
}

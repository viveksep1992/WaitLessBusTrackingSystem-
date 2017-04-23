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
    public partial class FrmLoginDetails : Form

    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter Adp;
        DataSet Ds;
       
        public FrmLoginDetails()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();
        }

        private void FrmLoginDetails_Load(object sender, EventArgs e)
        {
            this.Top = 80;
            AutoDated();
            cmd = new OleDbCommand("SELECT DISTINCT (UserName) FROM Login_Details", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UserType.Items.Add(dr.GetValue(0));
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmRegisteredUserDetails frm = new FrmRegisteredUserDetails();
            this.Hide();
            frm.Show();
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            cmd = new OleDbCommand("SELECT * FROM Login_Details WHERE UserName LIKE'" + UserType.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVLoginDetails.DataSource = Ds.Tables[0];
                dGVLoginDetails.AutoResizeColumns();
                
                LblCount.Text = "Total Logins Are = " + (dGVLoginDetails.Rows.Count-1) + " Times";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void AutoDated()
        {
            cmd = new OleDbCommand("SELECT DISTINCT (loginDate) FROM Login_Details", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dDated.Items.Add(dr.GetValue(0));
            }
        }

        private void dDated_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Login_Details WHERE loginDate LIKE'" + dDated.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVLoginDetails.DataSource = Ds.Tables[0];
                dGVLoginDetails.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;

                string ct = "DELETE FROM Login_Details WHERE [UserName] LIKE'" + dGVLoginDetails.SelectedCells[0].Value + "'";
                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserType.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

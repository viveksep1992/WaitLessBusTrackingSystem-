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
using System.Data.OleDb;
namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmRegisteredUserDetails : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter Adp;
        DataSet Ds;

        public FrmRegisteredUserDetails()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM User_Registration WHERE UserType LIKE'"+ UserType.SelectedItem +"'",con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVUserDetails.DataSource = Ds.Tables[0];
                dGVUserDetails.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmUserManagement frm = new FrmUserManagement();
            this.Hide();
            frm.Show();
        }

        private void btnLoginDetails_Click(object sender, EventArgs e)
        {
            FrmLoginDetails frm = new FrmLoginDetails();
            frm.MdiParent = this.MdiParent;
            this.Hide();
            frm.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegisteredUserDetails_Load(object sender, EventArgs e)
        {
            this.Top = 80;
        }
    }
}

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
using System.Drawing.Imaging;

namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmBusHoldersRecords : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet Ds;
        OleDbDataAdapter Adp;
        public FrmBusHoldersRecords()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();  
        }

        private void FrmBusHoldersRecords_Load(object sender, EventArgs e)
        {
            this.Top = 78; 
            AutoBusNo();
            AutoBusStop();
            AutoCourse();
            AutoSId();
        }

        public void AutoSId()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Stu_ID) FROM Bus", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSID.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoCourse()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Course) FROM Bus", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCourse.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoBusStop()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(B_Stop) FROM Bus", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBstop.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoBusNo()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(B_No) FROM Bus", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBno.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void cmbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Bus WHERE Stu_ID LIKE '" + cmbSID.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVBusHolders.DataSource = Ds.Tables[0];
                dGVBusHolders.AutoResizeColumns();
                dGVBusHolders.RowTemplate.Height = 75;
                DataGridViewColumn Col1 = dGVBusHolders.Columns[4];
                Col1.Width = 80;
                DataGridViewColumn Col2 = dGVBusHolders.Columns[11];
                Col2.Width = 80;
               for (int i = 0; i < dGVBusHolders.Columns.Count; i++)
                   if (dGVBusHolders.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dGVBusHolders.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                return;
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

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Bus WHERE Course LIKE '" + cmbCourse.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVBusHolders.DataSource = Ds.Tables[0];
                dGVBusHolders.AutoResizeColumns();
                dGVBusHolders.RowTemplate.Height = 75;
                DataGridViewColumn Col1 = dGVBusHolders.Columns[4];
                Col1.Width = 80;
                DataGridViewColumn Col2 = dGVBusHolders.Columns[11];
                Col2.Width = 80;
                for (int i = 0; i < dGVBusHolders.Columns.Count; i++)
                    if (dGVBusHolders.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dGVBusHolders.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBstop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Bus WHERE B_Stop LIKE '" + cmbBstop.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVBusHolders.DataSource = Ds.Tables[0];
                dGVBusHolders.AutoResizeColumns();
                dGVBusHolders.RowTemplate.Height = 75;
                DataGridViewColumn Col1 = dGVBusHolders.Columns[4];
                Col1.Width = 80;
                DataGridViewColumn Col2 = dGVBusHolders.Columns[11];
                Col2.Width = 80;
                for (int i = 0; i < dGVBusHolders.Columns.Count; i++)
                    if (dGVBusHolders.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dGVBusHolders.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Bus WHERE B_No LIKE '" + cmbBno.SelectedItem + "'", con);
            try
            {
                Ds = new DataSet();
                Adp = new OleDbDataAdapter(cmd);
                Adp.Fill(Ds);
                dGVBusHolders.DataSource = Ds.Tables[0];
                dGVBusHolders.AutoResizeColumns();
                dGVBusHolders.RowTemplate.Height = 75;
                DataGridViewColumn Col1 = dGVBusHolders.Columns[4];
                Col1.Width = 80;
                DataGridViewColumn Col2 = dGVBusHolders.Columns[11];
                Col2.Width = 80;
                for (int i = 0; i < dGVBusHolders.Columns.Count; i++)
                    if (dGVBusHolders.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dGVBusHolders.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmStudentBusRegistration f = new FrmStudentBusRegistration();
            this.Hide();
            f.Show();
        }

    }
}

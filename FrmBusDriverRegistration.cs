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
using System.Drawing.Imaging;
using System.IO;

namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmBusDriverRegistration : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public FrmBusDriverRegistration()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database.accdb");
            con.Open();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("INSERT INTO Transport VALUES(@B_ID,@B_No,@B_D_Name,@B_D_Contact,@D_Image)",con);

            cmd.Parameters.AddWithValue("@B_ID",TxtBusID.Text);
            cmd.Parameters.AddWithValue("@B_No", TxtBusNo.Text);
            cmd.Parameters.AddWithValue("@B_D_Name",TxtDriverName.Text);
            cmd.Parameters.AddWithValue("@B_D_Contact",mTxtContact.Text);

            MemoryStream ms = new MemoryStream();
            PicDriver.Image.Save(ms, ImageFormat.Jpeg);
            byte[] fromControl = ms.GetBuffer();
            cmd.Parameters.AddWithValue("@D_Image", fromControl);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Has Been Saved Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            String A;
            cmd = new OleDbCommand("UPDATE [Transport] SET [B_ID]=@B_ID,[B_No]=@B_No,[B_D_Name]=@B_D_Name,[B_D_Contact]=@B_D_Contact,[D_Image]=@D_Image", con);
             A = MessageBox.Show("Are You Sure", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
             if (A == "Yes")
             {
                 cmd.Parameters.AddWithValue("@B_ID", TxtBusID.Text);
                 cmd.Parameters.AddWithValue("@B_No", TxtBusNo.Text);
                 cmd.Parameters.AddWithValue("@B_D_Name", TxtDriverName.Text);
                 cmd.Parameters.AddWithValue("@B_D_Contact", mTxtContact.Text);

                 MemoryStream ms = new MemoryStream();
                 PicDriver.Image.Save(ms, ImageFormat.Jpeg);
                 byte[] fromControl = ms.GetBuffer();
                 cmd.Parameters.AddWithValue("@D_Image", fromControl);

                 cmd.ExecuteNonQuery();

                 MessageBox.Show("Data Has Been Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Save.Enabled = false;
            Delete.Enabled = true;
            CmdUpdate.Enabled = true;
            cmd = new OleDbCommand("SELECT * FROM Transport WHERE B_ID=" + TxtBusID.Text, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                   TxtBusID.Text=dr["B_ID"].ToString();
                    TxtBusNo.Text=dr["B_No"].ToString();
                    TxtDriverName.Text=dr["B_D_Name"].ToString();
                    mTxtContact.Text=dr["B_D_Contact"].ToString();
                    byte[] b = (byte[])dr["D_Image"];
                    MemoryStream ms = new MemoryStream(b);
                    PicDriver.Image = Image.FromStream(ms);
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String A;
            cmd = new OleDbCommand("DELETE FROM Transport WHERE B_ID=" + TxtBusID.Text, con);

            A = MessageBox.Show("Are You Sure", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (A == "Yes")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            CmdUpdate.Enabled = false;
            Save.Enabled = true;
            Delete.Enabled = false;
            Search.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Select Driver Image";
            PicDriver.Load(openFileDialog1.FileName);  
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmStudentBusRegistration f = new FrmStudentBusRegistration();
            this.Hide();
            f.Show();
        }
    }
}

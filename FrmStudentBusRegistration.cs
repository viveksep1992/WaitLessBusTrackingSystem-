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
    public partial class FrmStudentBusRegistration : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public FrmStudentBusRegistration()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();   
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
            BuSTop();
            BusNo();
            BtnGo.Enabled = false;
        }
        public void BuSTop()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(BuStop) FROM BuStop", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbBusSTOP.Items.Add(dr["BuStop"].ToString());
            }
            dr.Close();
        }

      
        private void Reset()
        {
            Stu_ID.Text = "";
            StudentName.Text = "";
            FatherName.Text = "";
            Course.Text = "";
            Stu_Pic.Image = Stu_Pic.InitialImage;
            CmbBusNo.Text = "";
            CmbBusSTOP.Text = "";
            mTxtDContact.Text = "";
            PicDriver.Image = PicDriver.InitialImage;
            TxtBusFee.Text = "";
            TxtDriverName.Text = "";
            TxtValidity.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            Stu_ID.Focus();
        }
        public void BusNo()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(B_No) FROM Transport", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbBusNo.Items.Add(dr.GetValue(0));
            }
            dr.Close();
        }


        private void FrmStudentBusRegistration_Load(object sender, EventArgs e)
        {
            this.Top = 78; 
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT(S_ID) FROM Student";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Stu_ID.Items.Add(dr.GetValue(0));
            }
            dr.Close();
        }
       

        private void CmbBusSTOP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT BuSfee FROM BuStop WHERE BuStop LIKE '" + CmbBusSTOP.SelectedItem + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtBusFee.Text = "₹ " + (dr["BuSfee"].ToString()) + ".00";

            }

            else
            {
                MessageBox.Show("No Record Available For Fee", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Close();
        }

        private void CmbBusNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT * FROM Transport WHERE B_No=" + CmbBusNo.SelectedItem, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtDriverName.Text = dr["B_D_Name"].ToString();
                mTxtDContact.Text = dr["B_D_Contact"].ToString();
                byte[] b = (byte[])dr["D_Image"];
                MemoryStream ms = new MemoryStream(b);
                PicDriver.Image = Image.FromStream(ms);
            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Stu_ID.Text == "")
            {
                MessageBox.Show("Please Select Student ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CmbBusSTOP.Text == "")
            {
                MessageBox.Show("Please Enter Bus Stop", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CmbBusNo.Text == "")
            {
                MessageBox.Show("Please Enter Bus Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtDriverName.Text == "")
            {
                MessageBox.Show("Please Enter Driver'S Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (mTxtDContact.Text == "")
            {
                MessageBox.Show("Please Enter Driver'S Contact Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                cmd = new OleDbCommand("INSERT INTO Bus (Stu_ID,StuName,FatherName,Course,Stu_Pic,B_Stop,B_No,B_D_Name,Contact,B_Fee,Validity,Pic) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@10,@P11,@P12)", con);
                cmd.Parameters.AddWithValue("@P1", Stu_ID.Text);
                cmd.Parameters.AddWithValue("@P2", StudentName.Text);
                cmd.Parameters.AddWithValue("@P3", FatherName.Text);
                cmd.Parameters.AddWithValue("@P4", Course.Text);
                MemoryStream ms1 = new MemoryStream();
                Stu_Pic.Image.Save(ms1, ImageFormat.Jpeg);
                byte[] fromControl1 = ms1.GetBuffer();
                cmd.Parameters.AddWithValue("@P5", fromControl1);
                cmd.Parameters.AddWithValue("@P6", CmbBusSTOP.Text);
                cmd.Parameters.AddWithValue("@P7", CmbBusNo.Text);
                cmd.Parameters.AddWithValue("@P8", TxtDriverName.Text);
                cmd.Parameters.AddWithValue("@P9", mTxtDContact.Text);
                cmd.Parameters.AddWithValue("@P10", TxtBusFee.Text);
                cmd.Parameters.AddWithValue("@P11", TxtValidity.Text);
                MemoryStream ms = new MemoryStream();
                PicDriver.Image.Save(ms, ImageFormat.Jpeg);
                byte[] fromControl = ms.GetBuffer();
                cmd.Parameters.AddWithValue("@P12", fromControl);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transportation Records Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                BtnGo.Enabled = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Stu_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("SELECT S_FName,S_LName,FName,C_Name,C_Sem,PIC FROM Student WHERE S_ID LIKE'" + Stu_ID.SelectedItem + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                StudentName.Text = dr["S_FName"].ToString() + " " + dr["S_LName"].ToString();
                FatherName.Text = dr["FName"].ToString();
                Course.Text = dr["C_Name"].ToString() + "-" + dr["C_Sem"].ToString();
                byte[] b = (byte[])dr["PIC"];
                MemoryStream ms = new MemoryStream(b);
                Stu_Pic.Image = Image.FromStream(ms);
            }
            dr.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Stu_ID FROM Bus WHERE Stu_ID LIKE'" + Stu_ID.Text + "'";
                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                  
                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                int RowsAffected = 0;

               
                string cq = "DELETE FROM Bus WHERE Stu_ID LIKE'" + Stu_ID.Text + "'";
                cmd = new OleDbCommand(cq);

                cmd.Connection = con;

                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                   
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            BusNo();
            BuSTop();
            btnSave.Enabled = false;
            btnUpdate_record.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                cmd = new OleDbCommand("SELECT * FROM Bus WHERE Stu_ID LIKE '" + Stu_ID.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    StudentName.Text = dr["StuName"].ToString();
                    FatherName.Text = dr["FatherName"].ToString();
                    Course.Text = dr["Course"].ToString();
                    byte[] b = (byte[])dr["Stu_Pic"];
                    MemoryStream ms = new MemoryStream(b);
                    Stu_Pic.Image = Image.FromStream(ms);
                    CmbBusSTOP.Text = dr["B_Stop"].ToString();
                    CmbBusNo.Text = dr["B_No"].ToString();
                    TxtDriverName.Text = dr["B_D_Name"].ToString();
                    mTxtDContact.Text = dr["Contact"].ToString();
                    TxtBusFee.Text = (dr["B_Fee"].ToString());
                    TxtValidity.Text = dr["Validity"].ToString();
                    byte[] b1 = (byte[])dr["D_Image"];
                    MemoryStream ms1 = new MemoryStream(b1);
                    PicDriver.Image = Image.FromStream(ms1);
                   
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("UPDATE [Bus] SET [Stu_ID]=@P1,[StuName]=@P2,[FatherName]=@P3,[Course]=@P4,[Stu_Pic]=@P5,[B_Stop]=@P6,[B_No]=@P7,[B_D_Name]=@P8,[Contact]=@P9,[B_Fee]=@P10,[Validity]=@P11,[Pic]=@P12 WHERE [Stu_ID]=@P1", con);

                cmd.Parameters.AddWithValue("@P1", Stu_ID.Text);
                cmd.Parameters.AddWithValue("@P2", StudentName.Text);
                cmd.Parameters.AddWithValue("@P3", FatherName.Text);
                cmd.Parameters.AddWithValue("@P4", Course.Text);
                MemoryStream ms1 = new MemoryStream();
                Stu_Pic.Image.Save(ms1, ImageFormat.Jpeg);
                byte[] fromControl1 = ms1.GetBuffer();
                cmd.Parameters.AddWithValue("@P5", fromControl1);
                cmd.Parameters.AddWithValue("@P6", CmbBusSTOP.Text);
                cmd.Parameters.AddWithValue("@P7", CmbBusNo.Text);
                cmd.Parameters.AddWithValue("@P8", TxtDriverName.Text);
                cmd.Parameters.AddWithValue("@P9", mTxtDContact.Text);
                cmd.Parameters.AddWithValue("@P10", TxtBusFee.Text);
                cmd.Parameters.AddWithValue("@P11", TxtValidity.Text);
                MemoryStream ms = new MemoryStream();
                PicDriver.Image.Save(ms, ImageFormat.Jpeg);
                byte[] fromControl = ms.GetBuffer();
                cmd.Parameters.AddWithValue("@P12", fromControl);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transportation Records Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                btnUpdate_record.Enabled = false;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            FrmBusHoldersRecords frm = new FrmBusHoldersRecords();
            frm.MdiParent = this.MdiParent;
            this.Hide();
            frm.Show();
        }

        private void dTPTo_ValueChanged(object sender, EventArgs e)
        {
            string d1, d2;
            d1 = dTPFrom.Value.Year.ToString();
            d2 = dTPTo.Value.Year.ToString();
            TxtValidity.Text = (Convert.ToInt32(d2) - Convert.ToInt32(d1)).ToString()+ "-Years";
        }

        private void BtnDriverReg_Click(object sender, EventArgs e)
        {
            FrmBusDriverRegistration f = new FrmBusDriverRegistration();
            f.MdiParent = this.MdiParent;
            this.Hide();
            f.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

             

    }
}

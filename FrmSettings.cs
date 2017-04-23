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
    public partial class FrmSettings : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        public FrmSettings()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database.accdb");
            con.Open();
            MessageBox.Show("Connected");
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            this.Top = 78;
            this.Left = 0;
            this.Width = MdiParent.Width-5;
            this.Height = (MdiParent.Height - this.Top-5)-27;
            LblRegistration.Width = this.Width;
        }

        private void BtnCourseSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Course FROM Course WHERE Course=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtCName.Text);
                cmd.Parameters["@find"].Value = TxtCName.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("CourseName Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCName.Text = "";
                    TxtCName.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Course VALUES(@Course)", con);
                cmd.Parameters.AddWithValue("@Course", TxtCName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved in Course");
                TxtCName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSemSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Semester FROM Semester WHERE Semester=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtSEM.Text);
                cmd.Parameters["@find"].Value = TxtSEM.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSEM.Text = "";
                    TxtSEM.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Semester VALUES(@Semester)", con);
                cmd.Parameters.AddWithValue("Semester", TxtSEM.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved in Semester");
                TxtSEM.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatchSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Batch FROM Batch WHERE Batch=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", txtBatch.Text);
                cmd.Parameters["@find"].Value = txtBatch.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Batch Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBatch.Text = "";
                    txtBatch.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Batch VALUES(@Batch)", con);
                cmd.Parameters.AddWithValue("Batch", txtBatch.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Batch Saved");
                txtBatch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BtnCategorySave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Category FROM Category WHERE Category=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtCategory.Text);
                cmd.Parameters["@find"].Value = TxtCategory.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Category Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCategory.Text = "";
                    TxtCategory.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Category VALUES(@Category)", con);
                cmd.Parameters.AddWithValue("Category", TxtCategory.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Saved");
                TxtCategory.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOccupationSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Occupation FROM Occupation WHERE Occupation=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtOccupation.Text);
                cmd.Parameters["@find"].Value = TxtOccupation.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Occupation Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtOccupation.Text = "";
                    TxtOccupation.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Occupation VALUES(@Occupation)", con);
                cmd.Parameters.AddWithValue("Occupation", TxtOccupation.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Occupation Saved");
                TxtOccupation.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void BtnBoardSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT Board FROM Board WHERE Board=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtBoard.Text);
                cmd.Parameters["@find"].Value = TxtBoard.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Board Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtBoard.Text = "";
                    TxtBoard.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO Board VALUES(@Board)", con);
                cmd.Parameters.AddWithValue("Board", TxtBoard.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Board Saved");
                TxtBoard.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnUniversitySave_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = "SELECT University FROM University WHERE University=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtUniversity.Text);
                cmd.Parameters["@find"].Value = TxtUniversity.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("University Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUniversity.Text = "";
                    TxtUniversity.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }
                cmd = new OleDbCommand("INSERT INTO University VALUES(@University)", con);
                cmd.Parameters.AddWithValue("University", TxtUniversity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("University Saved");
                TxtUniversity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }     
       

        private void ShowImg(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Save.png");
        }

        private void HideImg(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/savebtn.png");
        }

        private void UpdateIMG(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Update.png");
        }

        private void HideUPIMg(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Update1.png");
        }

        private void DelSHOW(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Delete.png");
        }

        private void DelHide(object sender, EventArgs e)
        {
            Button b =(Button)sender;
            b.Image = Image.FromFile("Images/Delete1.png");
        }

        private void AddSHOW(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Add2.png");
        }

        private void AddHide(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Add1.png");
        }

        private void GoSHOW(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Search2.png");
        }

        private void GoHide(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = Image.FromFile("Images/Search1.png");
        }

       

        private void BtNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBTN(object sender, EventArgs e)
        {
            BtNClose.Image = Image.FromFile("Images/Closed.png");
            BtNClose.ForeColor = Color.Orange;
        }

        private void HideBTN(object sender, EventArgs e)
        {
            BtNClose.Image = Image.FromFile("Images/Closed1.png");
            BtNClose.ForeColor = Color.White;
        }

        private void BtnCourseUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("UPDATE [Course] SET [Course]=@Course WHERE [Course]=@Course", con);
                cmd.Parameters.AddWithValue("@Course", TxtCName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course UpDated");
                TxtCName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCName_TextChanged(object sender, EventArgs e)
        {
            TxtCName.Text = TxtCName.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Course) FROM Course WHERE Course LIKE '"+ TxtCName.Text.TrimEnd() +"'",con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtCName.Text = dr["Course"].ToString();
            }
            dr.Close();
        }

        private void TxtSEM_TextChanged(object sender, EventArgs e)
        {
            TxtSEM.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Semester) FROM Semester WHERE Semester LIKE '" + TxtSEM.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtSEM.Text = dr["Semester"].ToString();
            }
            dr.Close();
        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
            txtBatch.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Batch) FROM Batch WHERE Batch LIKE '" + txtBatch.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtBatch.Text = dr["Batch"].ToString();
            }
            dr.Close();
        }

        private void TxtCategory_TextChanged(object sender, EventArgs e)
        {
            TxtCategory.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Category) FROM Category WHERE Category LIKE '" + TxtCategory.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtCategory.Text = dr["Category"].ToString();
            }
            dr.Close();
        }

        private void TxtOccupation_TextChanged(object sender, EventArgs e)
        {
            TxtOccupation.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Occupation) FROM Occupation WHERE Occupation LIKE '" + TxtOccupation.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtOccupation.Text = dr["Occupation"].ToString();
            }
            dr.Close();
        }

        private void TxtBoard_TextChanged(object sender, EventArgs e)
        {
            TxtBoard.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(Board) FROM Board WHERE Board LIKE '" + TxtBoard.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtBoard.Text = dr["Board"].ToString();
            }
            dr.Close();
        }

        private void TxtUniversity_TextChanged(object sender, EventArgs e)
        {
            TxtUniversity.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(University) FROM University WHERE University LIKE '" + TxtUniversity.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtUniversity.Text = dr["University"].ToString();
            }
            dr.Close();
        }

        private void TxtBStopName_TextChanged(object sender, EventArgs e)
        {
            TxtBStopName.Text.TrimEnd();
            cmd = new OleDbCommand("SELECT DISTINCT(BuStop) FROM BuStop WHERE BuStop LIKE '" + TxtBStopName.Text.TrimEnd() + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtBStopName.Text = dr["BuStop"].ToString();
            }
            dr.Close();
        }

        private void BtnSaveBusStop_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("INSERT INTO BuStop VALUES(@BuStop,@BuSfee)", con);
                cmd.Parameters.AddWithValue("BuStop", TxtBStopName.Text);
                cmd.Parameters.AddWithValue("BuSfee", TxtFee.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("BuStop & Fee Saved");
                TxtBStopName.Text = "";
                TxtFee.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

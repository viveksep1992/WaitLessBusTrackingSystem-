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
    public partial class FrmUserManagement : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        public FrmUserManagement()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database.accdb");
            con.Open();
        }

        private void Reset()
        {
            TxtUserName.Text = "";
            TxtPassword.Text = "";
            mTxtContactNo.Text = "+91";
            TxtName.Text = "";
            TxtEMail.Text = "";
            btnRegister.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            CmbUserType.Text= "";
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("Please Enter UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            if (CmbUserType.Text == "")
            {
                MessageBox.Show("Please Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            if (TxtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
            if (TxtName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtName.Focus();
                return;
            }
            if (mTxtContactNo.Text == "")
            {
                MessageBox.Show("Please Enter Contact No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtContactNo.Focus();
                return;
            }
            if (TxtEMail.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEMail.Focus();
                return;
            }
            try
            {

                string ct = "SELECT UserName FROM User_Registration WHERE UserName=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtUserName.Text);
                cmd.Parameters["@find"].Value = TxtUserName.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserName.Text = "";
                    TxtUserName.Focus();


                    if ((dr != null))
                    {
                        dr.Close();
                    }
                    return;
                }


                cmd = new OleDbCommand("INSERT INTO User_Registration VALUES(@UserName,@UserType,@Password,@U_Name,@Contact_No,@EMail)", con);

                cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@UserType", CmbUserType.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@U_Name", TxtName.Text);
                cmd.Parameters.AddWithValue("@Contact_No", mTxtContactNo.Text);
                cmd.Parameters.AddWithValue("@EMail", TxtEMail.Text);
                cmd.ExecuteNonQuery();



                cmd = new OleDbCommand("INSERT INTO Login VALUES(@UserName,@Password,@UserType)", con);
                cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@UserType", CmbUserType.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                Reset();
                btnRegister.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserName.Focus();
                    return;
                }
                string ct = "SELECT UserName FROM User_Registration WHERE UserName=@find";

                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@find", TxtUserName.Text);
                cmd.Parameters["@find"].Value = TxtUserName.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Already in Use, UserName is Not Available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!dr.Read())
                {
                    MessageBox.Show("UserName is Available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUserName.Focus();

                }
                if ((dr != null))
                {
                    dr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Autocomplete()
        {

           
            cmd = new OleDbCommand("SELECT UserName FROM User_Registration", con);
            DataSet ds = new DataSet();
            OleDbDataAdapter Adp = new OleDbDataAdapter(cmd);
            Adp.Fill(ds, "User_Registration");

           
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["UserName"].ToString());

            }
            TxtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtUserName.AutoCompleteCustomSource = col;
            TxtUserName.AutoCompleteMode = AutoCompleteMode.Suggest;

            
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            this.Top =100;
            Autocomplete();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate_record.Enabled = true;
            try
            {
                TxtUserName.Text = TxtUserName.Text.TrimEnd();

                cmd.CommandText = "SELECT * FROM User_Registration WHERE UserName LIKE '" + TxtUserName.Text.Trim() + "'";
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    CmbUserType.Text= dr["UserType"].ToString();
                    TxtPassword.Text = dr["Password"].ToString();
                    TxtName.Text = dr["U_Name"].ToString();
                    mTxtContactNo.Text = dr["Contact_No"].ToString();
                    TxtEMail.Text = dr["EMail"].ToString();
                }

                if ((dr != null))
                {
                    dr.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Really want to Delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;

                string cq = "DELETE FROM User_Registration WHERE UserName LIKE'" + TxtUserName.Text + "'";
                cmd = new OleDbCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();

                string ct = "DELETE FROM Login WHERE UserName LIKE'" + TxtUserName.Text + "'";
                cmd = new OleDbCommand(ct);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autocomplete();
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("UPDATE User_Registration SET [UserName]=@UserName,[UserType]=@UserType,[Password]=@Password,[U_Name]=@U_Name,[Contact_No]=@Contact_No,[EMail]=@EMail WHERE [UserName]=@UserName",con);

                cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@UserType", CmbUserType.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@U_Name", TxtName.Text);
                cmd.Parameters.AddWithValue("@Contact_No", mTxtContactNo.Text);
                cmd.Parameters.AddWithValue("@EMail", TxtEMail.Text);
                cmd.ExecuteNonQuery();


                string cb1 = "UPDATE Login SET [UserName]=@UserName,[Password]=@Password,[UserType]=@UserType WHERE [UserName]=@UserName";

                cmd = new OleDbCommand(cb1,con);
                cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@UserType", CmbUserType.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                Reset();
                btnRegister.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserName_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (TxtUserName.Text.Length > 0)
            {
                if (!rEMail.IsMatch(TxtUserName.Text))
                {
                    MessageBox.Show("Only Letters,Numbers and Underscore is Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserName.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void Name_Of_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void EMail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (TxtEMail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(TxtEMail.Text))
                {
                    MessageBox.Show("Invalid Email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEMail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            FrmRegisteredUserDetails frm = new FrmRegisteredUserDetails();
            frm.MdiParent = this.MdiParent;
            this.Hide();
            frm.Show();
        }
       
    }
}

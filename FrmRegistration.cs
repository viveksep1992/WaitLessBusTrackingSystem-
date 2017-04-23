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
using System.Security.Cryptography;


namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmRegistration : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public FrmRegistration()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();               
        }

        public void Reset()
        {
            EN_No.Text = "G";
            DOJ.Text = "";
            TxtAddFNo.Text = "";
            C_Name.Text = "";
            C_Sem.Text = "";
            Batch.Text = "";
            S_ID.Text = "";
            S_FName.Text = "";
            S_LName.Text = "";
            DOB.Text = "";
            CmbBGroup.Text = "";
            CmbCategory.Text = "";
            CmbGender.Text = "";
            CmbReligion.Text = "";
            Father.Text = "";
            Mother.Text = "";
            ChkAddress.Checked = false;
            Address1.Text = "";
            Address2.Text = "";
            City.Text = "";
            State.Text = "";
            Contact.Text = "013";
            Mobile.Text = "91";
            Email.Text = "";
            PIN.Text = "";
            P_Address1.Text = "";
            P_Address2.Text = "";
            P_City.Text = "";
            P_PIN.Text = "";
            P_State.Text = "";
            FOccupation.Text = "";
            PIC.Image = PIC.InitialImage;
            cmb10.Text = "";
            Mtxt10.Text = "";
            Cmb10Year.Text= "";
            cmb12.Text = "";
            Mtxt12.Text = "";
            Cmb12Year.Text = "";
            cmbUG.Text = "";
            MtxtUG.Text = "";
            CmbUGYear.Text = "";
            cmbPG.Text = "";
            MtxtPG.Text = "";
            CmbPGYear.Text = "";
            MtxtFContact.Text = "91";
            MtxtMContact.Text = "91";
            txtMEmail.Text = "";
            txtBirthPlace.Text = "";
            txtFEmail.Text = "";
            TxtMotherTongue.Text = "";
            CmbNationality.Text = "";
            MOccupation.Text = "";
                      
         }
     
        private void Save_Click_1(object sender, EventArgs e)
        {
           
            string str;
            try
            {
                Verification();  
                
                str = "INSERT INTO Student(S_ID,Add_No,Add_Date,Add_Form_No,C_Name,C_Sem,Batch,S_FName,";
                str = str + "S_LName,DOB,Religion,Category,BGroup,Nationality,BPlace,M_Tongue,Gen,PIC,";
                str = str + "FName,FOccupation,FContact,FEmail,MName,MOccupation,MContact,MEmail,Contact_No,";
                str = str + "Mobile_No,EMail,H_No1,Street1,City1,Pin1,State1,H_No2,Street2,City2,Pin2,State2,";
                str = str + "B_10,P_10,Y_10,B_12,P_12,Y_12,B_UG,P_UG,Y_UG,B_PG,P_PG,Y_PG)";
                str = str + "VALUES(@S_ID,@Add_No,@Add_Date,@Add_Form_No,@C_Name,@C_Sem,@Batch,@S_FName,";
                str = str + "@S_LName,@DOB,@Religion,@Category,@BGroup,@Nationality,@BPlace,M_Tongue,@Gen,@PIC,";
                str = str + "@FName,@FOccupation,@FContact,@FEmail,@MName,@MOccupation,@MContact,@MEmail,@Contact_No,";
                str = str + "@Mobile_No,@EMail,@H_No1,@Street1,@City1,@Pin1,@State1,@H_No2,@Street2,@City2,@Pin2,@State2,";
                str = str + "@B_10,@P_10,@Y_10,@B_12,@P_12,@Y_12,@B_UG,@P_UG,@Y_UG,@B_PG,@P_PG,@Y_PG)";

            cmd = new OleDbCommand(str, con);

            cmd.Parameters.AddWithValue("S_ID", S_ID.Text);
            cmd.Parameters.AddWithValue("@Add_No", EN_No.Text);
            cmd.Parameters.AddWithValue("@Add_Date", DOJ.Text);
            cmd.Parameters.AddWithValue("@Add_Form_No", TxtAddFNo.Text);
            cmd.Parameters.AddWithValue("@C_Name", C_Name.Text);
            cmd.Parameters.AddWithValue("@C_Sem", C_Sem.Text);
            cmd.Parameters.AddWithValue("@Batch", Batch.Text);        
            cmd.Parameters.AddWithValue("@S_FName", S_FName.Text);
            cmd.Parameters.AddWithValue("@S_LName", S_LName.Text);
            cmd.Parameters.AddWithValue("@DOB", DOB.Text);
            cmd.Parameters.AddWithValue("@Religion", CmbReligion.Text);
            cmd.Parameters.AddWithValue("@Category", CmbCategory.Text);
            cmd.Parameters.AddWithValue("@BGroup", CmbBGroup.Text);
            cmd.Parameters.AddWithValue("@Nationality",CmbNationality.Text);
            cmd.Parameters.AddWithValue("@BPlace",txtBirthPlace.Text);
            cmd.Parameters.AddWithValue("M_Tongue",TxtMotherTongue.Text);
            cmd.Parameters.AddWithValue("@Gen", CmbGender.Text);
                
            MemoryStream ms = new MemoryStream();
            PIC.Image.Save(ms, ImageFormat.Jpeg);
            byte[] fromControl = ms.GetBuffer();
            cmd.Parameters.AddWithValue("@PIC", fromControl);
            cmd.Parameters.AddWithValue("@FName",Father.Text);
            cmd.Parameters.AddWithValue("@FOccupation",FOccupation.Text);
            cmd.Parameters.AddWithValue("@FContact",MtxtFContact.Text);
            cmd.Parameters.AddWithValue("@FEmail",txtFEmail.Text);
            cmd.Parameters.AddWithValue("@MName",Mother.Text);
            cmd.Parameters.AddWithValue("@MOccupation",MOccupation.Text);
            cmd.Parameters.AddWithValue("@MContact",MtxtMContact.Text);
            cmd.Parameters.AddWithValue("@MEmail",txtMEmail.Text);
            cmd.Parameters.AddWithValue("@Contact_No", Contact.Text);
            cmd.Parameters.AddWithValue("@Mobile_No", Mobile.Text);
            cmd.Parameters.AddWithValue("@EMail", Email.Text);
            cmd.Parameters.AddWithValue("@H_No1", Address1.Text);
            cmd.Parameters.AddWithValue("@Street1", Address2.Text);
            cmd.Parameters.AddWithValue("@City1", City.Text);
            cmd.Parameters.AddWithValue("@Pin1", PIN.Text);
            cmd.Parameters.AddWithValue("@State1", State.Text);
            cmd.Parameters.AddWithValue("@H_No2", P_Address1.Text);
            cmd.Parameters.AddWithValue("@Street2", P_Address2.Text);
            cmd.Parameters.AddWithValue("@City2", P_City.Text);
            cmd.Parameters.AddWithValue("@Pin2", P_PIN.Text);
            cmd.Parameters.AddWithValue("@State2", P_State.Text);
            cmd.Parameters.AddWithValue("@B_10", cmb10.Text);
            cmd.Parameters.AddWithValue("@P_10", Mtxt10.Text);
            cmd.Parameters.AddWithValue("@Y_10", Cmb10Year.Text);
            cmd.Parameters.AddWithValue("@B_12", cmb12.Text);
            cmd.Parameters.AddWithValue("@P_12", Mtxt12.Text);
            cmd.Parameters.AddWithValue("@Y_12", Cmb12Year.Text);
            cmd.Parameters.AddWithValue("@B_UG", cmbUG.Text);
            cmd.Parameters.AddWithValue("@P_UG", MtxtUG.Text);
            cmd.Parameters.AddWithValue("@Y_UG", CmbUGYear.Text);
            cmd.Parameters.AddWithValue("@B_PG", cmbPG.Text);
            cmd.Parameters.AddWithValue("@P_PG", MtxtPG.Text);
            cmd.Parameters.AddWithValue("@Y_PG", CmbPGYear.Text);
                     
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Registered...","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Reset();
            S_ID.Enabled = true;
            S_ID.Update();
            Save.Enabled = false;
            AddNew.Enabled = true;
            Search.Enabled = true;
            C_Name.Items.Clear();
            C_Sem.Items.Clear();
            Batch.Items.Clear();
            
            CmbCategory.Items.Clear();
            FOccupation.Items.Clear();
            MOccupation.Items.Clear();
            cmb10.Items.Clear();
            cmb12.Items.Clear();
            cmbUG.Items.Clear();
            cmbPG.Items.Clear();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
           
        }

      
        private void CmdUpdate_Click(object sender, EventArgs e)
        {
             
            try
            {
                string str;
                string A;

                str = "UPDATE [Student] SET [S_ID]=@S_ID,[Add_No]=@Add_No,[Add_Date]=@Add_Date,[Add_Form_No]=@Add_Form_No,[C_Name]=@C_Name,[C_Sem]=@C_Sem,";
                str = str + "[Batch]=@Batch,[S_FName]=@S_FName,[S_LName]=@S_LName,[DOB]=@DOB,[Religion]=@Religion,[Category]=@Category,";
                str = str + "[BGroup]=@BGroup,[Nationality]=@Nationality,[BPlace]=@BPlace,[M_Tongue]=@M_Tongue,[Gen]=@Gen,[PIC]=@PIC,";
                str = str + "[FName]=@FName,[FOccupation]=@FOccupation,[FContact]=@FContact,[FEmail]=@FEmail,[MName]=@MName,[MOccupation]=@MOccupation,";
                str = str + "[MContact]=@MContact,[MEmail]=@MEmail,[Contact_No]=@Contact_No,[Mobile_No]=@Mobile_No,[EMail]=@EMail,[H_No1]=@H_No1,";
                str = str + "[Street1]=@Street1,[City1]=@City1,[Pin1]=@Pin1,[State1]=@State1,[H_No2]=@H_No2,[Street2]=@Street2,[City2]=@City2,[Pin2]=@Pin2,[State2]=@State2,";
                str = str + "[B_10]=@B_10,[P_10]=@P_10,[Y_10]=@Y_10,[B_12]=@B_12,[P_12]=@P_12,[Y_12]=@Y_12,[B_UG]=@B_UG,[P_UG]=@P_UG,[Y_UG]=@Y_UG,[B_PG]=@B_PG,[P_PG]=@P_PG,[Y_PG]=@Y_PG WHERE [S_ID]=@S_ID";


                cmd = new OleDbCommand(str, con);
                cmd.CommandText = str;
                cmd.Connection = con;
                A = MessageBox.Show("Are You Sure", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (A == "Yes")
                {
                    cmd.Parameters.AddWithValue("S_ID", S_ID.Text);
                    cmd.Parameters.AddWithValue("@Add_No", EN_No.Text);
                    cmd.Parameters.AddWithValue("@Add_Date", DOJ.Text);
                    cmd.Parameters.AddWithValue("@Add_Form_No", TxtAddFNo.Text);
                    cmd.Parameters.AddWithValue("@C_Name", C_Name.Text);
                    cmd.Parameters.AddWithValue("@C_Sem", C_Sem.Text);
                    cmd.Parameters.AddWithValue("@Batch", Batch.Text);
                    cmd.Parameters.AddWithValue("@S_FName", S_FName.Text);
                    cmd.Parameters.AddWithValue("@S_LName", S_LName.Text);
                    cmd.Parameters.AddWithValue("@DOB", DOB.Text);
                    cmd.Parameters.AddWithValue("@Religion", CmbReligion.Text);
                    cmd.Parameters.AddWithValue("@Category", CmbCategory.Text);
                    cmd.Parameters.AddWithValue("@BGroup", CmbBGroup.Text);
                    cmd.Parameters.AddWithValue("@Nationality", CmbNationality.Text);
                    cmd.Parameters.AddWithValue("@BPlace", txtBirthPlace.Text);
                    cmd.Parameters.AddWithValue("M_Tongue", TxtMotherTongue.Text);
                    cmd.Parameters.AddWithValue("@Gen", CmbGender.Text);

                    MemoryStream ms = new MemoryStream();
                    PIC.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] fromControl = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@PIC", fromControl);
                    cmd.Parameters.AddWithValue("@FName", Father.Text);
                    cmd.Parameters.AddWithValue("@FOccupation", FOccupation.Text);
                    cmd.Parameters.AddWithValue("@FContact", MtxtFContact.Text);
                    cmd.Parameters.AddWithValue("@FEmail", txtFEmail.Text);
                    cmd.Parameters.AddWithValue("@MName", Mother.Text);
                    cmd.Parameters.AddWithValue("@MOccupation", MOccupation.Text);
                    cmd.Parameters.AddWithValue("@MContact", MtxtMContact.Text);
                    cmd.Parameters.AddWithValue("@MEmail", txtMEmail.Text);
                    cmd.Parameters.AddWithValue("@Contact_No", Contact.Text);
                    cmd.Parameters.AddWithValue("@Mobile_No", Mobile.Text);
                    cmd.Parameters.AddWithValue("@EMail", Email.Text);
                    cmd.Parameters.AddWithValue("@H_No1", Address1.Text);
                    cmd.Parameters.AddWithValue("@Street1", Address2.Text);
                    cmd.Parameters.AddWithValue("@City1", City.Text);
                    cmd.Parameters.AddWithValue("@Pin1", PIN.Text);
                    cmd.Parameters.AddWithValue("@State1", State.Text);
                    cmd.Parameters.AddWithValue("@H_No2", P_Address1.Text);
                    cmd.Parameters.AddWithValue("@Street2", P_Address2.Text);
                    cmd.Parameters.AddWithValue("@City2", P_City.Text);
                    cmd.Parameters.AddWithValue("@Pin2", P_PIN.Text);
                    cmd.Parameters.AddWithValue("@State2", P_State.Text);
                    cmd.Parameters.AddWithValue("@B_10", cmb10.Text);
                    cmd.Parameters.AddWithValue("@P_10", Mtxt10.Text);
                    cmd.Parameters.AddWithValue("@Y_10", Cmb10Year.Text);
                    cmd.Parameters.AddWithValue("@B_12", cmb12.Text);
                    cmd.Parameters.AddWithValue("@P_12", Mtxt12.Text);
                    cmd.Parameters.AddWithValue("@Y_12", Cmb12Year.Text);
                    cmd.Parameters.AddWithValue("@B_UG", cmbUG.Text);
                    cmd.Parameters.AddWithValue("@P_UG", MtxtUG.Text);
                    cmd.Parameters.AddWithValue("@Y_UG", CmbUGYear.Text);
                    cmd.Parameters.AddWithValue("@B_PG", cmbPG.Text);
                    cmd.Parameters.AddWithValue("@P_PG", MtxtPG.Text);
                    cmd.Parameters.AddWithValue("@Y_PG", CmbPGYear.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DataBase UpDated Successfully...", "DataBase Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    S_ID.Refresh();
                    CmdUpdate.Enabled = false;
                    AddNew.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
                
            try
            {

                int RowsAffected = 0;

                cmd = new OleDbCommand("DELETE FROM Student WHERE S_ID LIKE'" + S_ID.Text +"'", con);
                RowsAffected = cmd.ExecuteNonQuery();

               
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully Deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    S_ID.Refresh();
                    Delete.Enabled = false;
                    AddNew.Enabled = true;
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
           
            this.Top = 78;
            this.Left = 0;     
            this.Width = MdiParent.Width-5;
            this.Height = (MdiParent.Height - this.Top-5)-27;
            LblRegistration.Width = this.Width;
            EN_No.Focus();
           
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT (S_ID) FROM Student";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                S_ID.Items.Add(dr.GetValue(0));
              
            }
            dr.Close();
            
        }

        private void colorChange(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Lime;
            t.ForeColor = Color.Red;
        }

        private void colorCHANGE1(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void ChangeCOLOR(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.BackColor = Color.Lime;
            cb.ForeColor = Color.Red;
        }

        private void ChangeCOLOR1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.BackColor = Color.White;
            cb.ForeColor = Color.Black;
        }

        private void CHGcolor(object sender, EventArgs e)
        {
            MaskedTextBox mt = (MaskedTextBox)sender;
            mt.BackColor = Color.Lime;
            mt.ForeColor = Color.Red;
        }

        private void CHGcolor1(object sender, EventArgs e)
        {
            MaskedTextBox mt = (MaskedTextBox)sender;
            mt.BackColor = Color.White;
            mt.ForeColor = Color.Black;
        }

        private void Address1_TextChanged(object sender, EventArgs e)
        {
            if (ChkAddress.Checked)
            {
                P_Address1.Text = Address1.Text;
            }
        }

        private void Address2_TextChanged(object sender, EventArgs e)
        {
            if (ChkAddress.Checked)
            {
                P_Address2.Text = Address2.Text;
            }
        }

        private void City_TextChanged(object sender, EventArgs e)
        {
            if (ChkAddress.Checked)
            {
                P_City.Text = City.Text;
            }
        }

        private void PIN_TextChanged(object sender, EventArgs e)
        {
            if (ChkAddress.Checked)
            {
                P_PIN.Text = PIN.Text;
            }
        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            P_State.Text = State.Text;
        }

        private void Add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Select Student Image";
            PIC.Load(openFileDialog1.FileName);  
        }

        private void Search_Click(object sender, EventArgs e)
        {
            AutoCourse();
            AutoOccupation();
            AutoCategory();
            AutoSem();
            AutoBatch();
            AutoBoard();
            AutoUniversity();
            Save.Enabled = false;
            Delete.Enabled = true;
            CmdUpdate.Enabled = true;
            S_ID.Enabled = true;
            cmd = new OleDbCommand("SELECT * FROM Student WHERE S_ID LIKE'" + S_ID.Text + "'",con);
            OleDbDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    S_ID.Text = dr["S_ID"].ToString();
                    EN_No.Text = dr["Add_No"].ToString();
                    DOJ.Text = dr["Add_Date"].ToString();
                    TxtAddFNo.Text = dr["Add_Form_No"].ToString();
                    C_Name.Text = dr["C_Name"].ToString();
                    C_Sem.Text = dr["C_Sem"].ToString();
                    Batch.Text = dr["Batch"].ToString();
                    S_FName.Text = dr["S_FName"].ToString();
                    S_LName.Text = dr["S_LName"].ToString();
                    DOB.Text = dr["DOB"].ToString();
                    CmbReligion.Text = dr["Religion"].ToString();
                    CmbCategory.Text = dr["Category"].ToString();
                    CmbBGroup.Text = dr["BGroup"].ToString();
                    CmbNationality.Text = dr["Nationality"].ToString();
                    txtBirthPlace.Text = dr["BPlace"].ToString();
                    TxtMotherTongue.Text = dr["M_Tongue"].ToString();
                    CmbGender.Text = dr["Gen"].ToString();

                    byte[] b = (byte[])dr["PIC"];
                    MemoryStream ms = new MemoryStream(b);
                    PIC.Image = Image.FromStream(ms);
                    Father.Text = dr["FName"].ToString();
                    FOccupation.Text = dr["FOccupation"].ToString();
                    MtxtFContact.Text = dr["FContact"].ToString();
                    txtFEmail.Text = dr["FEmail"].ToString();
                    Mother.Text = dr["MName"].ToString();
                    MOccupation.Text = dr["MOccupation"].ToString();
                    MtxtMContact.Text = dr["MContact"].ToString();
                    txtMEmail.Text = dr["MEmail"].ToString();
                    Contact.Text = dr["Contact_No"].ToString();
                    Mobile.Text = dr["Mobile_No"].ToString();
                    Email.Text = dr["EMail"].ToString();
                    Address1.Text = dr["H_No1"].ToString();
                    Address2.Text = dr["Street1"].ToString();
                    City.Text = dr["City1"].ToString();
                    PIN.Text = dr["Pin1"].ToString();
                    State.Text = dr["State1"].ToString();
                    P_Address1.Text = dr["H_No2"].ToString();
                    P_Address2.Text = dr["Street2"].ToString();
                    P_City.Text = dr["City2"].ToString();
                    P_PIN.Text = dr["Pin2"].ToString();
                    P_State.Text = dr["State2"].ToString();
                    cmb10.Text = dr["B_10"].ToString();
                    Mtxt10.Text = dr["P_10"].ToString();
                    Cmb10Year.Text = dr["Y_10"].ToString();
                    cmb12.Text = dr["B_12"].ToString();
                    Mtxt12.Text = dr["P_12"].ToString();
                    Cmb12Year.Text = dr["Y_12"].ToString();
                    cmbUG.Text = dr["B_UG"].ToString();
                    MtxtUG.Text = dr["P_UG"].ToString();
                    CmbUGYear.Text = dr["Y_UG"].ToString();
                    cmbPG.Text = dr["B_PG"].ToString();
                    MtxtPG.Text = dr["P_PG"].ToString();
                    CmbPGYear.Text = dr["Y_PG"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record found, Please Check Student No You Entered", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CmdUpdate.Enabled = false;
                    Delete.Enabled = false;
                    Reset();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        public void AutoCourse()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Course) FROM Course",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                C_Name.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoSem()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Semester) FROM Semester", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               C_Sem.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoBatch()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Batch) FROM Batch", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               Batch.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoCategory()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Category) FROM Category", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbCategory.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoOccupation()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Occupation) FROM Occupation", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                FOccupation.Items.Add(dr.GetValue(0).ToString());
                MOccupation.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoBoard()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(Board) FROM Board", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb10.Items.Add(dr.GetValue(0).ToString());
                cmb12.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        public void AutoUniversity()
        {
            cmd = new OleDbCommand("SELECT DISTINCT(University) FROM University", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUG.Items.Add(dr.GetValue(0).ToString());
                cmbPG.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void CHKUG_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKUG.Checked)
            {
                cmbUG.Enabled = true;
                MtxtUG.Enabled = true;
                CmbUGYear.Enabled = true;
            }
            else
            {
                cmbUG.Enabled = false;
                MtxtUG.Enabled = false;
                CmbUGYear.Enabled = false;
            }
        }

        private void CHKPG_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKPG.Checked)
            {
                cmbPG.Enabled = true;
                MtxtPG.Enabled = true;
                CmbPGYear.Enabled = true;
            }
            else
            {
                cmbPG.Enabled = false;
                MtxtPG.Enabled = false;
                CmbPGYear.Enabled = false;
            }
        }

        private void S_ID_TextChanged(object sender, EventArgs e)
        {
            if (S_ID.Text == "")
            {
                return;
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            Reset();
            EN_No.Focus();
            AutoCourse();
            AutoOccupation();
            AutoCategory();
            AutoSem();
            AutoBatch();
            AutoBoard();
            AutoUniversity();
            CmdUpdate.Enabled = false;
            Save.Enabled = true;
            Delete.Enabled = false;
            Search.Enabled = false;
            autoSID();
            S_ID.Enabled = false;
         
        }

      

        private void ShowIMG(object sender, EventArgs e)
        {
            AddNew.Image = Image.FromFile("Images/New1.png");
        }

        private void HideIMG(object sender, EventArgs e)
        {
            AddNew.Image = Image.FromFile("Images/New2.png");
        }

        private void ShowSave(object sender, EventArgs e)
        {
            Save.Image = Image.FromFile("Images/S1.png");
        }

        private void HideSave(object sender, EventArgs e)
        {
            Save.Image = Image.FromFile("Images/S2.png");
        }

        private void ShowUpdate(object sender, EventArgs e)
        {
            CmdUpdate.Image = Image.FromFile("Images/U1.png");
        }

        private void HideUpdate(object sender, EventArgs e)
        {
            CmdUpdate.Image = Image.FromFile("Images/U2.png");
        }

        private void ShowDel(object sender, EventArgs e)
        {
            Delete.Image = Image.FromFile("Images/D1.png");
        }

        private void HideDel(object sender, EventArgs e)
        {
            Delete.Image = Image.FromFile("Images/D2.png");
        }

        private void ShowClose(object sender, EventArgs e)
        {
            Exit.Image = Image.FromFile("Images/E1.png");
        }

        private void HideClose(object sender, EventArgs e)
        {
            Exit.Image = Image.FromFile("Images/E2.png");
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void autoSID()
        {
            S_ID.Text = "A-" + GetUniqueKey(5);
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (Email.Text.Length > 0)
            {
                if (!rEMail.IsMatch(Email.Text))
                {
                    MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void TabStudentDetails_DrawItem(object sender, DrawItemEventArgs e)
        {
            //get tabpage
            TabPage tabPages = TabStudentDetails.TabPages[e.Index];
            Graphics graphics = e.Graphics;
            Brush textBrush = new SolidBrush(Color.White); //fore color brush
            Rectangle tabBounds = TabStudentDetails.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                graphics.FillRectangle(Brushes.Blue, e.Bounds); //fill background color
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font tabFont = new Font("Cambria", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Near;
            // draw text
            graphics.DrawString(tabPages.Text, tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
        }

        private void KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }


        private bool Verification()
        {
            if (EN_No.Text == "G")
            {
                EN_No.Focus();
                string errorEnrollmentNumber = "Please Provide Enrollment Number";
                errorPro.SetError(EN_No, errorEnrollmentNumber);
                MessageBox.Show("Please Provide Enrollment Number");
                return false;
            }
            if (C_Name.Text == string.Empty)
            {
                C_Name.Focus();
                string errorCousrse = "Please Choose Course";
                errorPro.SetError(C_Name, errorCousrse);
                return false;
            }
            if (C_Sem.Text == string.Empty)
            {
                C_Sem.Focus();
                string errorSemester = "Please Choose Semester";
                errorPro.SetError(C_Sem, errorSemester);
                MessageBox.Show("Please Choose Semester");
                return false;
            }
            if (Batch.Text == string.Empty)
            {
                Batch.Focus();
                string errorBatch = "Please Choose Batch";
                errorPro.SetError(Batch, errorBatch);
                return false;
            }
            if (S_FName.Text == string.Empty)
            {
                S_FName.Focus();
                string errorFname = "Please Provide First Name";
                errorPro.SetError(S_FName, errorFname);
                MessageBox.Show("Please Provide First Name");
                return false;
            }
            if (DOB.Text == string.Empty)
            {
                DOB.Focus();
                string errorDOB = "Please Provide Date Of Birth";
                errorPro.SetError(DOB, errorDOB);
                return false;
            }
            if (Father.Text == string.Empty)
            {
                Father.Focus();
                string errorFather = "Please Provide Father Name";
                errorPro.SetError(Father, errorFather);
                return false;
            }
            if (MtxtFContact.Text == "+91-")
            {
                MtxtFContact.Focus();
                string errorMtxtFContact = "Please Provide Father Contact Number";
                errorPro.SetError(MtxtFContact, errorMtxtFContact);
                return false;
            }
            return true;
        }

        private void EN_No_TextChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void C_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void C_Sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void Batch_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void S_FName_TextChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void Father_TextChanged(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

       
    }
}

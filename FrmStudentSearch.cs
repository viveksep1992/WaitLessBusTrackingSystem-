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
    public partial class FrmStudentSearch : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter Adp;
        DataSet Ds;
        
        public FrmStudentSearch()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;Data Source=Database.accdb");
            con.Open();
            MessageBox.Show("Database Connected");
        }

        private void FrmStudentSearch_Load(object sender, EventArgs e)
        {
            this.Top = 78;
            this.Left = 0;
            this.Width = MdiParent.Width-5;
            this.Height = (MdiParent.Height - this.Top-5)-27;
            LblRegistration.Width = this.Width;


        }

        private void TxtStuSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtStuSearch.Text == "")
            {
                MessageBox.Show("Please Enter Student Bus ID/ID/Addmission No./Name/EnRolment No.","DataBase Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (rdBtnStuName.Checked)
            {
                cmd = new OleDbCommand("SELECT ADD_No,S_ID,S_FName,S_LName,FName,C_Name,C_Sem,PIC FROM Student WHERE S_FName LIKE '" + TxtStuSearch.Text + "%'", con);
                try
                {
                    Ds = new DataSet();
                    Adp = new OleDbDataAdapter(cmd);
                    Adp.Fill(Ds);
                    dGStudentView.DataSource = Ds.Tables[0];
                    dGStudentView.AutoResizeColumns();
                    LblCount.Text = "Total Nos Of Students Are: = " + (dGStudentView.Rows.Count - 1);
                    DataGridViewColumn Colm = dGStudentView.Columns[4];
                    Colm.Width = 150;
                    DataGridViewColumn Col1 = dGStudentView.Columns[0];
                    Col1.Width = 80;
                    DataGridViewColumn Col2 = dGStudentView.Columns[5];
                    Col2.Width = 80;
                    DataGridViewColumn Col3 = dGStudentView.Columns[6];
                    Col3.Width = 70;
                    DataGridViewColumn Column = dGStudentView.Columns[7];
                    Column.Width = 80;
                    dGStudentView.RowTemplate.Height = 75;
                    
                    for (int i = 0; i < dGStudentView.Columns.Count; i++)
                        if (dGStudentView.Columns[i] is DataGridViewImageColumn)
                        {
                            ((DataGridViewImageColumn)dGStudentView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                            break;
                        }
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
                if (rdBtnENRollNo.Checked)
                {
                    cmd = new OleDbCommand("SELECT ADD_No,S_ID,S_FName,S_LName,FName,C_Name,C_Sem,PIC FROM Student WHERE Add_No LIKE '" + TxtStuSearch.Text + "%'", con);
                    try
                    {
                        Ds = new DataSet();
                        Adp = new OleDbDataAdapter(cmd);
                        Adp.Fill(Ds);
                        dGStudentView.DataSource = Ds.Tables[0];
                        dGStudentView.AutoResizeColumns();
                        LblCount.Text = "Total Nos Of Students Are: = " + (dGStudentView.Rows.Count - 1);
                        DataGridViewColumn Colm = dGStudentView.Columns[4];
                        Colm.Width = 150;
                        DataGridViewColumn Col1 = dGStudentView.Columns[0];
                        Col1.Width = 80;
                        DataGridViewColumn Col2 = dGStudentView.Columns[5];
                        Col2.Width = 80;
                        DataGridViewColumn Col3 = dGStudentView.Columns[6];
                        Col3.Width = 70;
                        DataGridViewColumn Column = dGStudentView.Columns[7];
                        Column.Width = 80;
                        dGStudentView.RowTemplate.Height = 75;
                        for (int i = 0; i < dGStudentView.Columns.Count; i++)
                            if (dGStudentView.Columns[i] is DataGridViewImageColumn)
                            {
                                ((DataGridViewImageColumn)dGStudentView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                                break;
                            }
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                    if(rdBtnAddNo.Checked)
                {
                    cmd = new OleDbCommand("SELECT ADD_No,S_ID,S_FName,S_LName,FName,C_Name,C_Sem,PIC FROM Student WHERE S_ID LIKE '" + TxtStuSearch.Text +"%'", con);
                    try
                    {
                        Ds = new DataSet();
                        Adp = new OleDbDataAdapter(cmd);
                        Adp.Fill(Ds);
                        dGStudentView.DataSource = Ds.Tables[0];
                        dGStudentView.AutoResizeColumns();
                        LblCount.Text = "Total Nos Of Students Are: = " + (dGStudentView.Rows.Count - 1);
                        DataGridViewColumn Colm = dGStudentView.Columns[4];
                        Colm.Width = 150;
                        DataGridViewColumn Col1 = dGStudentView.Columns[0];
                        Col1.Width = 80;
                        DataGridViewColumn Col2 = dGStudentView.Columns[5];
                        Col2.Width = 80;
                        DataGridViewColumn Col3 = dGStudentView.Columns[6];
                        Col3.Width = 70;
                        DataGridViewColumn Column = dGStudentView.Columns[7];
                        Column.Width = 80;
                        dGStudentView.RowTemplate.Height = 75;
                        for (int i = 0; i < dGStudentView.Columns.Count; i++)
                            if (dGStudentView.Columns[i] is DataGridViewImageColumn)
                            {
                                ((DataGridViewImageColumn)dGStudentView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                                break;
                            }
                        return;
                    }       
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                    if (rdBtnBusNo.Checked)
                    {
                        try
                        {
                            cmd = new OleDbCommand("SELECT Stu_ID,StuName,FatherName,Course,Stu_Pic,B_Stop,B_No FROM Bus WHERE B_No LIKE'" + TxtStuSearch.Text + "'", con);
                       
                            Ds = new DataSet();
                            Adp = new OleDbDataAdapter(cmd);
                            Adp.Fill(Ds);
                            dGStudentView.DataSource = Ds.Tables[0];
                            dGStudentView.AutoResizeColumns();
                            LblCount.Text = "Total Nos Of Students Are: = " + (dGStudentView.Rows.Count - 1);
                            DataGridViewColumn Column = dGStudentView.Columns[4];
                            Column.Width = 80;
                            DataGridViewColumn Col1 = dGStudentView.Columns[5];
                            Col1.Width = 150;
                           
                            dGStudentView.RowTemplate.Height = 75;
                            
                            for (int i = 0; i < dGStudentView.Columns.Count; i++)
                                if (dGStudentView.Columns[i] is DataGridViewImageColumn)
                                {
                                    ((DataGridViewImageColumn)dGStudentView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                                    break;
                                }
                            return;
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   

        }

        private void NewIMG(object sender, EventArgs e)
        {
            btnCLOSE.Image = Image.FromFile("Images/Closed.png");
            btnCLOSE.ForeColor = Color.Orange;
        }

        private void OldIMG(object sender, EventArgs e)
        {
            btnCLOSE.Image = Image.FromFile("Images/Closed1.png");
            btnCLOSE.ForeColor = Color.White;
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SHowIMG(object sender, EventArgs e)
        {
            Search.Image = Image.FromFile("Images/Go1.png");
        }

        private void ShowIMG1(object sender, EventArgs e)
        {
            Search.Image = Image.FromFile("Images/GO.png");
        }

        private void rdBtnAddNo_CheckedChanged(object sender, EventArgs e)
        {
            TxtStuSearch.Enabled = true;
            TxtStuSearch.BackColor = Color.Black;
            TxtStuSearch.ForeColor = Color.Lime;
            TxtStuSearch.Focus();
        }

        private void rdBtnStuName_CheckedChanged(object sender, EventArgs e)
        {
            TxtStuSearch.Enabled = true;
            TxtStuSearch.BackColor = Color.Black;
            TxtStuSearch.ForeColor = Color.Lime;
            TxtStuSearch.Focus();
        }

        private void rdBtnENRollNo_CheckedChanged(object sender, EventArgs e)
        {
            TxtStuSearch.Enabled = true;
            TxtStuSearch.BackColor = Color.Black;
            TxtStuSearch.ForeColor = Color.Lime;
            TxtStuSearch.Focus();
        }

        private void dGStudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dGStudentView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("SELECT * FROM Student WHERE [S_ID] LIKE'" + dGStudentView.SelectedCells[0].Value + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
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
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
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
                graphics.FillRectangle(Brushes.BlueViolet, e.Bounds); //fill background color
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font tabFont = new Font("Times New Roman", 18, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Near;
            // draw text
            graphics.DrawString(tabPages.Text, tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
        }

        private void rdBtnBusNo_CheckedChanged(object sender, EventArgs e)
        {
            TxtStuSearch.Enabled = true;
            TxtStuSearch.BackColor = Color.Black;
            TxtStuSearch.ForeColor = Color.Lime;
            TxtStuSearch.Focus();
        }

       

       
    }
}

using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Drawing.Imaging;
using System.IO;
using System.Data.OleDb;


namespace WaitLess_Bus_Tracking_System
{
    public partial class FrmBusTrack : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        Double x, y;
        Pushpin pin;
        public FrmBusTrack()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=stu.accdb");
            con.Open();
            MessageBox.Show("Connected to Database");
        }

        private void FrmBusTrack_Load(object sender, EventArgs e)
        {
           
            this.Top = 78;
            this.Left = 0;
            this.Width = MdiParent.Width-5;
            this.Height = (MdiParent.Height - this.Top-5)-27;
        }

        private void txtNameAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtNameAdd.Text == "")
            {
                return;
            }
            userControl11.mymap.Children.Remove(pin);

            cmd = new OleDbCommand("SELECT * FROM BusLocation WHERE Busid=" + txtNameAdd.Text, con);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                x = Convert.ToDouble(dr["x"].ToString());
                y = Convert.ToDouble(dr["y"].ToString());
                Location pinLocation = new Location(x, y);

                pin = new Pushpin();
                pin.Location = pinLocation;


                userControl11.mymap.Children.Add(pin);
                userControl11.mymap.SetView(pinLocation, 15);


                byte[] b = (byte[])dr["photo"];
                MemoryStream ms = new MemoryStream(b);
                picIMAGE.Image = System.Drawing.Image.FromStream(ms);

               LblNameAdd.Text = "Current Location: "+ dr["address"].ToString() + "        Mobile No:" + dr["mob_num"].ToString();
               label1.Text="Driver'S Name: "+dr["sname"].ToString();

            }
        }

        private void ShowImg(object sender, EventArgs e)
        {
            btnCLOSE.Image = System.Drawing.Image.FromFile("Images/Closed.png");
            btnCLOSE.ForeColor = System.Drawing.Color.Orange;
        }

        private void HideImg(object sender, EventArgs e)
        {
            btnCLOSE.Image = System.Drawing.Image.FromFile("Images/Closed1.png");
            btnCLOSE.ForeColor = System.Drawing.Color.White;
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        
        }

    }
}

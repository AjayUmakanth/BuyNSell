using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BuyNSell
{
    public partial class Form7 : Form
    {
        String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Matharishwa\\git repos\\BuyNSell\\BuyNSell\\Database3.mdf\"; Integrated Security=True;MultipleActiveResultSets=True";

        //String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection con;
        public static string selectedPID = "";
        static Boolean isOwner = false;
        public Form7(string pid)
        {
            selectedPID = pid;
            InitializeComponent();
            setValues();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        public void setValues()
        {

            con = new SqlConnection(str);
            con.Open();

            String qry1 = $"Select * from [Property] where PID={selectedPID};";
            SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
            dr.Read();
            PID.Text = dr[0].ToString();
            UID.Text = dr[1].ToString();
            NAME.Text = dr[2].ToString();
            ADDRESS.Text = dr[3].ToString();
            LOCALITY.Text = dr[4].ToString();
            CITY.Text = dr[5].ToString();
            ASKPRICE.Text = dr[6].ToString();
            AVAILABILITY.Text = dr[7].ToString() == "True" ? "Yes" : "No";
            TYPE.Text = dr[8].ToString();
            if (AVAILABILITY.Text.Equals("No"))
                button1.Hide();
            else
            {

                if (UID.Text.ToString().Equals(Form3.UID))
                {
                    isOwner = true;
                    button1.Text = "Check Bids";
                }
                else
                { 
                    isOwner = false;
                    button1.Text = "Bid";
                }
            }
            dr.Close();


            String qry2 = $"Select * from [{TYPE.Text.ToString()}] where PID={selectedPID};";
            dr = new SqlCommand(qry2, con).ExecuteReader();
            dr.Read();
            AREA.Text = dr[1].ToString();
            NOROOMS.Text = dr[2].ToString();
            NOFLOORS.Text = dr[3].ToString();
            FLOORNO.Text = dr[4].ToString();
            PARKING.Text = dr[5].ToString();
            ROADWIDTH.Text = dr[6].ToString();
            REGDATE.Text = dr[7].ToString().Substring(0,10);
            GARDEN.Text = dr[8].ToString() == "1" ? "Present" : "Absent";
            CORNER.Text = dr[9].ToString() == "1" ? "Yes" : "No";
            ADDITIONAL.Text = dr[10].ToString();
            var img = (dr[11]);  

            if (img == DBNull.Value)
            {
                photo.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream((byte[])img);
                photo.Image = System.Drawing.Image.FromStream(mstream);
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
         
           
            
        }
        //this function is to resize image file
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!isOwner)
            {
                if (MessageBox.Show($"Do you want to bid on this property ??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form8 obj = new Form8();
                    obj.Show();
                    this.Hide();
                }            
            }
            else
            {
                Form9 obj = new Form9();
                obj.Show();
                this.Hide();
            }
        }


        private void IMAGE_Click(object sender, EventArgs e)
        {

        }

        private void CITY_Click(object sender, EventArgs e)
        {

        }

        private void REGDATE_Click(object sender, EventArgs e)
        {

        }

        private void PARKING_Click(object sender, EventArgs e)
        {

        }

        private void ADDITIONAL_Click(object sender, EventArgs e)
        {

        }

        private void ASKPRICE_Click(object sender, EventArgs e)
        {

        }

        private void FLOORNO_Click(object sender, EventArgs e)
        {

        }

        private void NOROOMS_Click(object sender, EventArgs e)
        {

        }

        private void NOFLOORS_Click(object sender, EventArgs e)
        {

        }

        private void AREA_Click(object sender, EventArgs e)
        {

        }

        private void UID_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void GARDEN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CORNER_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AVAILABILITY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void NAME_Click(object sender, EventArgs e)
        {

        }

        private void ADDRESS_Click(object sender, EventArgs e)
        {

        }

        private void LOCALITY_Click(object sender, EventArgs e)
        {

        }

        private void PID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
//
        }

        private void ROADWIDTH_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
    
    private void GARDEN_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void AVAILABILITY_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}

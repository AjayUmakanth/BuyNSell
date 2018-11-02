using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuyNSell
{
    public partial class MyProperties_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public static MyProperties_UserControl _instance;
        public static MyProperties_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyProperties_UserControl();
                return _instance;
            }
        }
        public MyProperties_UserControl()
        {
            InitializeComponent();
        }
        public void getBids()
        {
            con.Open();
            String syntax = $"SELECT * FROM [User] WHERE email='{Form3.UID}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            con.Close();
        }
        private void MyProperties_UserControl_Load(object sender, EventArgs e)
        {

        }



        public void showDetails()
        {
            con.Open();

            //CHeck THis LIne--->
            String syntax = $"SELECT * FROM [PROPERTY] WHERE UID='{Form3.UID}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            PID.Text = dr[0].ToString();
            LOCALITY.Text = dr[1].ToString();
            UID.Text = dr[2].ToString();
            ADDRESS.Text = dr[3].ToString();
            NAME.Text = dr[4].ToString();
           
            con.Close();
        }
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
       // public static string PID1;
       private void PID_Click(object sender, EventArgs e)
       {
      //      PID1 = showDetails();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.Show();
        }

      
    }
}
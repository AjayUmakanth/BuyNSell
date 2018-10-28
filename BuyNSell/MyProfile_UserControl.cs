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
    public partial class MyProfile_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private static MyProfile_UserControl _instance;
        public static MyProfile_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyProfile_UserControl();
                return _instance;
            }
        }

        public MyProfile_UserControl()
        {
            InitializeComponent();
        }

        private void MyProfile_UserControl_Load(object sender, EventArgs e)
        {
        }
        public void showDetails()
        {            
            con.Open();
            String syntax = $"SELECT * FROM [User] WHERE email='{Form3.uEmail}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            UID.Text = dr[0].ToString();
            name.Text = dr[1].ToString();
            email.Text = dr[2].ToString();
            phone.Text = dr[4].ToString();
            income.Text = dr[5].ToString();
            address.Text = dr[6].ToString();
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

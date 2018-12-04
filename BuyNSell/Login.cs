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


namespace BuyNSell
{
    public partial class Login : Form
    {
        //public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Matharishwa\\git repos\\BuyNSell\\BuyNSell\\Database3.mdf\Integrated Security=True";
        public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private String authenticate(String uName)
        {
            con.Open();
            String syntax = $"SELECT password FROM [User] WHERE email='{uName}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            String temp = "";
            if (dr.HasRows)
            {
                dr.Read();
                temp = dr[0].ToString();
            }
            con.Close();
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label4.Hide(); 
            String email = textBox1.Text, pass = authenticate(email),typedPass= textBox2.Text,uid; 
            if (pass.Equals(""))
                label5.Show();
            else
            {
                if (pass.Equals(typedPass))
                {
                    con.Open();
                    String syntax = $"SELECT UID FROM [User] WHERE email='{email}'";
                    cmd = new SqlCommand(syntax, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    uid = dr[0].ToString();
                    con.Close();
                    User_Details obj = new User_Details(uid);
                    this.Hide();
                    obj.Show();                   
            }
                else
                    label4.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register obj = new Register();
            this.Hide();
            obj.Show();

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

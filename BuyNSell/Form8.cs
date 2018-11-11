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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Matharishwa\\git repos\\BuyNSell\\BuyNSell\\Database3.mdf\"; Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            error.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Hide();
            if (MessageBox.Show($"Do you want to bid on this property ??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bid.Text == "")
                    error.Show();
                else
                {
                    con.Open();
                    String qry1 = $"Insert into [Bids] (UID,PID,BidPrice) values ({Form3.UID},{Form7.selectedPID},{bid.Text});";
                    SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
                    con.Close();
                    MessageBox.Show("Your bid added");
                    this.Hide();
                }
            }
        }
    }
}

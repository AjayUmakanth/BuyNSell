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
    public partial class Enter_Bid : Form
    {
        SqlConnection con = new SqlConnection(Login.connectionString);

        public Enter_Bid()
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
                    String qry1 = $"Insert into [Bids] (UID,PID,BidPrice) values ({User_Details.UID},{Property_Viewer.selectedPID},{bid.Text});";
                    SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
                    con.Close();
                    MessageBox.Show("Your bid is added!!");
                    this.Hide();
                    MyBids_UserControl.Instance.refreshDataGridView(User_Details.UID);
                    //
                }
            }
        }

        private void bid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

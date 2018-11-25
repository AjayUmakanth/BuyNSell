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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(Form1.connectionString);
        SqlCommand cmd;

        public Form9()
        {
            InitializeComponent();
            refreshDataGridView();
        }
        public void refreshDataGridView()
        {
            con.Open();
            String syntax = $"SELECT UID,BidPrice FROM [Bids] WHERE PID ={Form7.selectedPID}"; 
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            bidProp.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bidProp.Rows[e.RowIndex];
                String selected_uid = row.Cells["UID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see user '{selected_uid}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form10 obj = new Form10(selected_uid, Form7.selectedPID, row.Cells["BidPrice"].Value.ToString());
                    obj.Show();
                 
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}

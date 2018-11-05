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
    public partial class MyBids_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private static MyBids_UserControl _instance;
        public static MyBids_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyBids_UserControl();
                return _instance;
            }
        }
        public MyBids_UserControl()
        {
            InitializeComponent();
            refreshDataGridView();
        }
        public void refreshDataGridView()
        {
            con.Open();
            String syntax = $"SELECT [Bids].PID,PropertyName,BidPrice,AskPrice FROM [Bids] ,[Property] WHERE [Bids].UID = '{Form3.UID}' and [Bids].PID= [Property].PID";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            myBidsView.DataSource = dt;
        }

        private void MyBids_UserControl_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        private void myPropView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myBidsView.Rows[e.RowIndex];
                String selected_pid = row.Cells["PID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see property '{row.Cells["PropertyName"].Value.ToString()}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form7 obj = new Form7(selected_pid);
                    obj.Show();
                    refreshDataGridView();
                    this.myBidsView.Refresh();
                }

            }
        }
    }
}

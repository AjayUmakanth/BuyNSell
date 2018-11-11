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
    public partial class Buy_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private static Buy_UserControl _instance;
        public static Buy_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Buy_UserControl();
                return _instance;
            }
        }

        public Buy_UserControl()
        {
            InitializeComponent();
            refreshDataGridView(Form3.UID);
        }

        public void refreshDataGridView(string uid)
        {
            con.Open();
            String syntax = $"SELECT PID,PropertyName,Address,City_Name,Locality_Name,AskPrice,Availablity FROM [Property] WHERE Type='Buy' and UID not in ({uid})";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            myPropView.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buy_UserControl_Load(object sender, EventArgs e)
        {
            refreshDataGridView(Form3.UID);
        }

        private void myPropView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myPropView.Rows[e.RowIndex];
                String selected_pid = row.Cells["PID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see property '{row.Cells["PropertyName"].Value.ToString()}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form7 obj = new Form7(selected_pid);
                    obj.Show();
                    refreshDataGridView(Form3.UID);
                    this.myPropView.Refresh();
                }

            }
        }
    }
}

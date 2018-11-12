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
/// <summary>
/// run it onced
/// </summary>
namespace BuyNSell
{
    public partial class MyProperties_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Matharishwa\\git repos\\BuyNSell\\BuyNSell\\Database3.mdf\"; Integrated Security=True");
        // SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
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
            refreshDataGridView(Form3.UID);
            this.myPropView.Refresh();
        }
        private void MyProperties_UserControl_Load(object sender, EventArgs e)
        {
            this.myPropView.Refresh();
            refreshDataGridView(Form3.UID);
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

        private void label22_Click(object sender, EventArgs e)
        {

        }
      
        public void refreshDataGridView(string uid)
        {
            con.Open();
            String syntax = $"SELECT PID,PropertyName,Address,City_Name,Locality_Name,AskPrice,Availablity,Type FROM [Property] WHERE UID='{uid}'";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            myPropView.DataSource = dt;
            this.myPropView.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myPropView.Rows[e.RowIndex];
                String selected_pid = row.Cells["PID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see property '{row.Cells["PropertyName"].Value.ToString()}'??","Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
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
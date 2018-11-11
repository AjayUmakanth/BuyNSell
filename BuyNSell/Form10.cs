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
    public partial class Form10 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Matharishwa\\git repos\\BuyNSell\\BuyNSell\\Database3.mdf\"; Integrated Security=True");
        //  SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        public static string UIDMP;
        public static string PIDMP;
        public static string price;
        SqlCommand cmd;

        SqlDataReader dr;
        public Form10(string uid,String pid,string priceProp)
        {
            UIDMP = uid;
            PIDMP = pid;
            price = priceProp;
            InitializeComponent();
            showDetails(UIDMP);
        }
       

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        public void showDetails(string uid)
        {
            UIDMP = uid;
            con.Open();
            String syntax = $"SELECT * FROM [User] WHERE UID='{UIDMP}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            UID.Text = dr[0].ToString();
            name.Text = dr[1].ToString();
            email.Text = dr[2].ToString();
            phone.Text = dr[4].ToString();
            income.Text = dr[5].ToString();
            address.Text = dr[6].ToString();
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to sell to user '{UID.Text}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                String qry1 = $"DELETE FROM [Bids] WHERE PID={Form7.selectedPID}";
                String qry2 = $"UPDATE [Property] SET UID='{UIDMP}',Availablity=0 WHERE PID={Form7.selectedPID} ";
                String qry3 = $"INSERT INTO [Transaction] (customer_UID,owner_UID,PID,price,date) values " +
                    $"({UIDMP},{Form3.UID},{PIDMP},{price},'{DateTime.Now}');";
                //need to refresh it after that 
                SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
                MessageBox.Show("querry1 executed");
                dr.Close();
                dr = new SqlCommand(qry2, con).ExecuteReader();
                dr.Close();
                MessageBox.Show("querry2 executed");

                dr = new SqlCommand(qry3, con).ExecuteReader();
                dr.Close();
                MessageBox.Show("querry3 executed");



                dr.Close();
                con.Close();
                MessageBox.Show("Transaction completed successfully");
                MyProperties_UserControl.Instance.refreshDataGridView(Form3.UID);


            }
        }
    }
}
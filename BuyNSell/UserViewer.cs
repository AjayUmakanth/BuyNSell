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
    public partial class UserViewer : Form
    {

        SqlConnection con = new SqlConnection(Login.connectionString);
       
        public static string UIDMP;
        public static string PIDMP;
        public static int price;
        SqlCommand cmd;

        SqlDataReader dr;
        public UserViewer(string uid,String pid,string priceProp)
        {
            UIDMP = uid;
            PIDMP = pid;
            price = Convert.ToInt32(priceProp);
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
            CashTransaction cash = new CashTransaction();
            Boolean moneyRecieved = cash.removeMoney(price, UIDMP); 
            con.Open();
           // SqlTransaction trans = con.BeginTransaction("Sellng Property");
            try {
                if (MessageBox.Show($"Do you want to sell to user '{UID.Text}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String qry1 = $"DELETE FROM [Bids] WHERE PID={Property_Viewer.selectedPID}";
                    String qry2 = $"UPDATE [Property] SET UID='{UIDMP}',Availablity=0,AskPrice=0 WHERE PID={Property_Viewer.selectedPID} ";
                    String qry3 = $"INSERT INTO [Transaction] (customer_UID,owner_UID,PID,price,date) values " +
                        $"({UIDMP},{User_Details.UID},{PIDMP},{price},@date);";
                    //need to refresh it after that 
                    if (moneyRecieved)
                        cash.addMoney(price, User_Details.UID);
                    else
                        throw new Exception("User: "+UIDMP+" dosent has enough cash in wallet\n\n");
                    dr = new SqlCommand(qry1, con).ExecuteReader();
                    dr.Close();
                    dr = new SqlCommand(qry2, con).ExecuteReader();
                    dr.Close();

                    cmd = new SqlCommand(qry3, con);
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Today;
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    dr.Close();;
                    MessageBox.Show("Transaction completed successfully");
                    MyProperties_UserControl.Instance.refreshDataGridView(User_Details.UID);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
      //          trans.Rollback();
                if(moneyRecieved)
                    cash.addMoney(price, UIDMP);
            }
            con.Close();
        }
    }
}
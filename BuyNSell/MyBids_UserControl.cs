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
        }

        private void MyBids_UserControl_Load(object sender, EventArgs e)
        {

        }
        public void getBids()
        {
            con.Open();
            String syntax = $"SELECT * FROM [User] WHERE email='{Form3.uEmail}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            con.Close();
        }
    }
}

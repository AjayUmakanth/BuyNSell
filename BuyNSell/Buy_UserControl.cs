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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buy_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

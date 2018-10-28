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
    public partial class MyProperties_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private static MyProperties_UserControl _instance;
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
        }

        private void MyProperties_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

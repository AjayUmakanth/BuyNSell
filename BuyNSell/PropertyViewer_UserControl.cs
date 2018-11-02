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
    public partial class PropertyViewer_UserControl : UserControl
    {   //REMOVE THIS IF ANY ERROR
        
       // public PropertyViewer_UserControl(String pid)
       // {
        //      PID = this.pid;
        //    InitializeComponent();

          //  PropertyViewer_UserControl.Instance.Dock = DockStyle.Fill;
          //  PropertyViewer_UserControl.Instance.showDetails();
         //   PropertyViewer_UserControl.Instance.BringToFront();
      //  }
        //TILL HERE
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private static MyProperties_UserControl _instance;
      //  private Label pid;

        public static MyProperties_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyProperties_UserControl();
                return _instance;
            }
        }
        public PropertyViewer_UserControl()
        {
            InitializeComponent();
        }

        private void PropertyViewer_UserControl_Load(object sender, EventArgs e)
        {

        }
        public void showDetails()
        {
            con.Open();
            String syntax = $"SELECT * FROM [property] WHERE UID='{Form3.UID}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            PID.Text = dr[0].ToString();
            LOCALITY.Text = dr[1].ToString();
            UID.Text = dr[2].ToString();
            ADDRESS.Text = dr[3].ToString();
            NAME.Text = dr[4].ToString();
            CITY.Text = dr[5].ToString();
            ADDRESS.Text = dr[6].ToString();
            con.Close();

            con.Open();
            //////////////////////////////////////////////////////////////
            string syntax1 = $"SELECT * FROM [rent] WHERE PID=1";
            cmd = new SqlCommand(syntax1, con);
            dr = cmd.ExecuteReader();
            dr.Read();
           
            AREA.Text = dr[1].ToString();
            NOROOMS.Text = dr[2].ToString();
            NOFLOORS.Text = dr[3].ToString();
            FLOORNO.Text = dr[4].ToString();
            CORNER.Text = dr[5].ToString();
            AVAILABILITY.Text = dr[6].ToString();
            PARKING.Text = dr[7].ToString();
            REGDATE.Text = dr[8].ToString();
            ASKPRICE.Text = dr[9].ToString();
            ROADWIDTH.Text = dr[10].ToString();
            GARDEN.Text = dr[11].ToString();
            ADDITIONAL.Text = dr[12].ToString();

            con.Close();
        }

        public void getBids()
        {
            con.Open();
            String syntax = $"SELECT * FROM [User] WHERE email='{Form3.UID}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void road_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void myProperties_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

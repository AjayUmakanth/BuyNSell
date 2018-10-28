using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyNSell
{
    public partial class Form3 : Form
    {
        public static String uEmail;
        public Form3(String email)
        {
            uEmail = email;
            InitializeComponent();
            contentPanel.Controls.Add(MyProfile_UserControl.Instance);
            MyProfile_UserControl.Instance.Dock = DockStyle.Fill;
            MyProfile_UserControl.Instance.showDetails();
            MyProfile_UserControl.Instance.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!contentPanel.Controls.Contains(MyProfile_UserControl.Instance))
            {
                contentPanel.Controls.Add(MyProfile_UserControl.Instance);
                MyProfile_UserControl.Instance.Dock = DockStyle.Fill;
            }
            MyProfile_UserControl.Instance.showDetails();
            MyProfile_UserControl.Instance.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(MyProperties_UserControl.Instance))
            {
                contentPanel.Controls.Add(MyProperties_UserControl.Instance);
                MyProperties_UserControl.Instance.Dock = DockStyle.Fill;
            }
            MyProperties_UserControl.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(MyBids_UserControl.Instance))
            {
                contentPanel.Controls.Add(MyBids_UserControl.Instance);
                MyBids_UserControl.Instance.Dock = DockStyle.Fill;
            }
            MyBids_UserControl.Instance.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Buy_UserControl.Instance))
            {
                contentPanel.Controls.Add(Buy_UserControl.Instance);
                Buy_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Buy_UserControl.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Rent_UserControl.Instance))
            {
                contentPanel.Controls.Add(Rent_UserControl.Instance);
                Rent_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Rent_UserControl.Instance.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            uEmail = "";
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
    }
}

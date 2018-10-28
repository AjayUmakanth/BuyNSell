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
        public Form3()
        {
            InitializeComponent();
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

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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

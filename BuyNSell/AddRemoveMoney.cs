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
    public partial class AddRemoveMoney : Form
    {
        
        public AddRemoveMoney()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            CashTransaction add = new CashTransaction();
            add.addMoney(Convert.ToInt32(textBox1.Text),User_Details.UID);
            MyProfile_UserControl.Instance.showDetails(User_Details.UID);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashTransaction remove = new CashTransaction();
            if (textBox1.Text != "")
            {
                if (!remove.removeMoney(Convert.ToInt32(textBox1.Text), User_Details.UID))
                    MessageBox.Show("You do not have the required balance");
                MyProfile_UserControl.Instance.showDetails(User_Details.UID);
                this.Close();
            }
            else
                MessageBox.Show("Field is empty");

        }

        private void AddRemoveMoney_Load(object sender, EventArgs e)
        {

        }
    }
}

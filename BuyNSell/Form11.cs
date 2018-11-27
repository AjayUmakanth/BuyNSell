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
    public partial class Form11 : Form
    {
        
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            CashTransaction add = new CashTransaction();
            add.addMoney(Convert.ToInt32(textBox1.Text),Form3.UID);
            MyProfile_UserControl.Instance.showDetails(Form3.UID);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashTransaction remove = new CashTransaction();
            if (! remove.removeMoney(Convert.ToInt32(textBox1.Text), Form3.UID))
                MessageBox.Show("You do not have the required balance");
            MyProfile_UserControl.Instance.showDetails(Form3.UID);
            this.Close();

        }
    }
}

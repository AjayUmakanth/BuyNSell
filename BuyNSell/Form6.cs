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
using System.IO;

namespace BuyNSell
{
    public partial class Form6 : Form
    {
        String str;
        String imgLoacation = "";
        SqlConnection con;
        public Form6()
        {
            InitializeComponent();
            cities.DropDownStyle = ComboBoxStyle.DropDownList;
            locality.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                String qry = "Select Name from [City]";
                SqlDataReader dr = new SqlCommand(qry,con).ExecuteReader();
                while (dr.HasRows) 
                {
                    dr.Read();
                    cities.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                image.Text = dialog.FileName.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imagePath = null;
            if (image.Text != "")
            {
                FileStream stream = new FileStream(image.Text, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(stream);
                imagePath = binary.ReadBytes((int)stream.Length);
            }

        }
    }
}

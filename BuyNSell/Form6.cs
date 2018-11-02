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
        String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True";
        string cityName;
        string locName;
        string type;
        SqlConnection con;
        public Form6()
        {
            InitializeComponent();
            cities.DropDownStyle = ComboBoxStyle.DropDownList;
            locality.DropDownStyle = ComboBoxStyle.DropDownList;
            Buy_Rent.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            cityName = (string)comboBox.SelectedItem;
            try
            {
                locality.Items.Clear();
                con = new SqlConnection(str);
                String qry = $"Select Name from [Locality] where City_Name='{cityName}'";
                con.Open();
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    locality.Items.Add(dr[0].ToString());
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
            ComboBox comboBox = (ComboBox)sender;
            locName = (string)comboBox.SelectedItem;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
             try
            {
                con = new SqlConnection(str);
                String qry = "Select Name from [City]";
                con.Open();
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    cities.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }

            Buy_Rent.Items.Add("Buy");
            Buy_Rent.Items.Add("Rent");

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
            int available = (availability.Checked) ? 1 : 0;
            int gard = (garden.Checked) ? 1 : 0;
            int corn = (corner.Checked) ? 1 : 0;
            try
            {
                if (image.Text != "")
                {
                    FileStream stream = new FileStream(image.Text, FileMode.Open, FileAccess.Read);
                    imagePath = new BinaryReader(stream).ReadBytes((int)stream.Length);
                }
                String property_name = PName.Text;
                String qry1 = $"Insert into property (Locality_Name,UID,Address,PropertyName,City_Name) values ('{locName}',{Form3.UID},'{Address.Text}','{PName}','{cities.SelectedItem}');";
                String qry2 = $"Select * from Property where UID='{Form3.UID}'and PropertyName='{PName}';";
                String qry3 = $"Insert into {type} (PID,Area,Rooms,NoFloors,Floor,Corner,Availability,Parking,RegYear,AskPrice,Road,Garden,Additional,Photo) values ('{locName}',{Form3.UID},'{Address.Text}','{PName}','{cities.SelectedItem}');";


                con = new SqlConnection(str);
                con.Open();
                SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
                MessageBox.Show("Data1 added successfully");
                con.Close();
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader dr2 = new SqlCommand(qry2, con).ExecuteReader();
                dr2.Read();
                label2.Text= dr[0].ToString();
                con.Close();
                MessageBox.Show("Data2 added successfully");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            type = (string)comboBox.SelectedItem;
        }
        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}

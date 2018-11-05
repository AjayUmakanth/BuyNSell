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
        String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security=True;MultipleActiveResultSets=True";
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
            String pidVal = "";

            try
            {
                if (image.Text != "")
                {
                    FileStream stream = new FileStream(image.Text, FileMode.Open, FileAccess.Read);
                    imagePath = new BinaryReader(stream).ReadBytes((int)stream.Length);
                }

                String property_name = PName.Text;
                con = new SqlConnection(str);
                con.Open();

                String qry1 = $"Insert into property (UID,PropertyName,Address,City_Name,Locality_Name,AskPrice,Availablity,Type) values " +
                    $"({Form3.UID},'{PName.Text}','{Address.Text}','{cities.SelectedItem}','{locName}',{askPrice.Text},{available},'{type}');";
                SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();


                String qry2 = $"Select PID from Property where UID='{Form3.UID}'and PropertyName='{PName.Text}';";
                dr = new SqlCommand(qry2, con).ExecuteReader();
                dr.Read();
                pidVal = dr[0].ToString();


                dr.Close();
                String qry3 = $"Insert into {type} (PID,Area,Rooms,NoFloors,Floor,Parking,Road,RegYear,Garden,Corner,Additional,Photo) " +
                   $"values ({pidVal},{area.Text},{rooms.Text},{noFloor.Text},{floorNo.Text},{parking.Text},{roads.Text},@regYear,{gard},{corn},'{additional.Text}',@imagePath);";
                SqlCommand cmd = new SqlCommand(qry3, con);
                cmd.Parameters.Add("@regYear", SqlDbType.Date).Value = regDate.Value.Date;
                if (imagePath != null)
                    cmd.Parameters.Add("@imagePath", imagePath);
                else
                    cmd.Parameters.Add("@imagePath", SqlDbType.VarBinary).Value = DBNull.Value;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peoperty Created successfully");
                dr.Close();

                Form6 obj = new Form6();
                this.Hide();
                obj.Refresh();
                obj.Show();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.ToString());
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

        private void rooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void floorNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

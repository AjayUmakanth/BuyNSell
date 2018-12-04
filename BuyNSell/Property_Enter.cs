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
    public partial class Property_Enter : Form
    {
        SqlConnection con = new SqlConnection(Login.connectionString);
        string cityName;
        string locName;
        string type;
        string selectedpid;
        public Property_Enter()
        {
            InitializeComponent();
            cities.DropDownStyle = ComboBoxStyle.DropDownList;
            locality.DropDownStyle = ComboBoxStyle.DropDownList;
            Buy_Rent.DropDownStyle = ComboBoxStyle.DropDownList;
            editOptions(false);
        }
        public void editOptions(Boolean isEdit)
        {
            if(isEdit)
            {
                cities.Hide();
                citiesLabel.Show();
                Buy_Rent.Hide();
                Buy_RentText.Show();
                locality.Hide();
                localityText.Show();
                button1.Text = "Save";
            }
            else
            {
                cities.Show();
                citiesLabel.Hide();
                Buy_Rent.Show();
                Buy_RentText.Hide();
                locality.Show();
                localityText.Hide();
                button1.Text = "Create";
            }
        }
        public void showData(string selectedPID)
        {
            editOptions(true);
            String qry1 = $"Select * from Property where PID='{selectedPID}';";
            con.Open();
            SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
            dr.Read();
            PName.Text = dr[2].ToString();
            Address.Text = dr[3].ToString();
            citiesLabel.Text = dr[5].ToString();
            localityText.Text = dr[4].ToString();
            askPrice.Text = dr[6].ToString();
            availability.Checked =dr[7].ToString()=="True"?true:false;
            Buy_RentText.Text = dr[8].ToString();
            String qry2 = $"Select * from {Buy_RentText.Text} where PID='{selectedPID}'";
            dr.Close();
            dr = new SqlCommand(qry2, con).ExecuteReader();
            dr.Read();
            area.Text = dr[1].ToString();
            rooms.Text = dr[2].ToString();
            noFloor.Text = dr[3].ToString();
            floorNo.Text = dr[4].ToString();
            parking.Text = dr[5].ToString();
            roads.Text = dr[6].ToString();
            regDate.Text = dr[7].ToString();
            garden.Checked = dr[8].ToString() == "True" ? true : false;
            corner.Checked = dr[9].ToString() == "True" ? true : false;
            additional.Text = dr[10].ToString();
            selectedpid = selectedPID;
            dr.Close();
            con.Close();
        }
        private void addData()
        {

            byte[] imagePath = null;
            int available = (availability.Checked) ? 1 : 0;
            int gard = (garden.Checked) ? 1 : 0;
            int corn = (corner.Checked) ? 1 : 0;
            String pidVal = "";
            SqlDataReader dr;
                if (image.Text != "")
                {
                    FileStream stream = new FileStream(image.Text, FileMode.Open, FileAccess.Read);
                    imagePath = new BinaryReader(stream).ReadBytes((int)stream.Length);
                }

                String property_name = PName.Text;
                con.Open();
                String qry1 = $"Insert into property (UID,PropertyName,Address,City_Name,Locality_Name,AskPrice,Availablity,Type) values " +
                    $"({User_Details.UID},'{PName.Text}','{Address.Text}','{cities.SelectedItem}','{locName}',{askPrice.Text},{available},'{type}');";
                 dr = new SqlCommand(qry1, con).ExecuteReader();
                dr.Close();

                String qry2 = $"Select PID from Property where UID='{User_Details.UID}'and PropertyName='{PName.Text}';";
                dr = new SqlCommand(qry2, con).ExecuteReader();
                dr.Read();
                pidVal = dr[0].ToString();
                dr.Close();


                String qry3 = $"Insert into {type} (PID,Area,Rooms,NoFloors,Floor,Parking,Road,RegYear,Garden,Corner,Additional,Photo) " +
                   $"values ({pidVal},{area.Text},{rooms.Text},{noFloor.Text},{floorNo.Text},{parking.Text},{roads.Text},@regYear,{gard},{corn},'{additional.Text}',@imagePath);";
                SqlCommand cmd = new SqlCommand(qry3, con);
                cmd.Parameters.Add("@regYear", SqlDbType.Date).Value = regDate.Value.Date;
                if (imagePath != null)

                {
                    cmd.Parameters.Add("@imagePath", imagePath);
                }
                else
                    cmd.Parameters.Add("@imagePath", SqlDbType.VarBinary).Value = DBNull.Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Peoperty Created successfully");
                dr.Close();
                con.Close();

                MyProperties_UserControl.Instance.refreshDataGridView(User_Details.UID);
                this.Hide();
            
 

        }
        private void saveData()
        {

            byte[] imagePath = null;
            int available = (availability.Checked) ? 1 : 0;
            int gard = (garden.Checked) ? 1 : 0;
            int corn = (corner.Checked) ? 1 : 0;
            String pidVal = "";

                if (image.Text != "")
                {
                    FileStream stream = new FileStream(image.Text, FileMode.Open, FileAccess.Read);
                    imagePath = new BinaryReader(stream).ReadBytes((int)stream.Length);
                }

                String property_name = PName.Text;
                con.Open();
                String qry1 = $"Update property set PropertyName='{PName.Text}',Address='{Address.Text}',AskPrice={askPrice.Text},Availablity={available} where PID={selectedpid} ;"; 
                SqlDataReader dr = new SqlCommand(qry1, con).ExecuteReader();
                dr.Close();
                String qry2 = $"Update {Buy_RentText.Text} set Area={area.Text},Rooms={rooms.Text},NoFloors={noFloor.Text},Floor={floorNo.Text},Parking={parking.Text}," +
                    $"Road={roads.Text},RegYear=@regYear,Garden={gard},Corner={corn},Additional='{additional.Text}' where PID={selectedpid}; ";
                

                if (imagePath != null)
                {
                    qry2 = $"Update {Buy_RentText.Text} set Area={area.Text},Rooms={rooms.Text},NoFloors={noFloor.Text},Floor={floorNo.Text},Parking={parking.Text}," +
                       $"Road={roads.Text},RegYear=@regYear,Garden={gard},Corner={corn},Additional={additional.Text},Photo=@imagePath where PID={selectedpid}; ";

                }
                SqlCommand cmd = new SqlCommand(qry2, con);
                cmd.Parameters.Add("@regYear", SqlDbType.Date).Value = regDate.Value.Date;
                if (imagePath != null)
                    cmd.Parameters.Add("@imagePath", imagePath);

                cmd.ExecuteReader();
                
                MessageBox.Show("Changes Saved successfully");
                dr.Close();
                con.Close();
                MyProperties_UserControl.Instance.refreshDataGridView(User_Details.UID);
                Property_Viewer obj = new Property_Viewer(selectedpid);
                obj.Show();
                this.Hide();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            cityName = (string)comboBox.SelectedItem;
            try
            {
                locality.Items.Clear();
                String qry = $"Select Name from [Locality] where City_Name='{cityName}'";
                con.Open();
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    locality.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
                con.Close();
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
                String qry = "Select Name from [City]";
                con.Open();
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    cities.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
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
            if (button1.Text.Equals("Create"))
                addData();
            else
                saveData();
            
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

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click_3(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void garden_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void askPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void noFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void floor_no_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuyNSell
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(Login.connectionString);

        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UserAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            Boolean added = true;
            cmd.Parameters.AddWithValue("@Name",textBox1.Text);
            cmd.Parameters.AddWithValue("@Email",textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", Convert.ToInt64(textBox4.Text));
            cmd.Parameters.AddWithValue("@Income", Convert.ToInt64(textBox5.Text));
            cmd.Parameters.AddWithValue("@Address", textBox6.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error\n" + ex);
                added = false;
            }
            con.Close();
            if(added)
                MessageBox.Show("Data added succesfully");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
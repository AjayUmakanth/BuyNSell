﻿using System;
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
    public partial class Bought_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(Login.connectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        private static Bought_UserControl _instance;
        public static Bought_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bought_UserControl();
                return _instance;
            }
        }
        public Bought_UserControl()
        {
            InitializeComponent();
        }
        public void refreshDataGridView(string uid)
        {
            con.Open();
            String syntax = $"SELECT TID,owner_UID,PID,price,date FROM [Transaction] WHERE customer_UID ='{uid}'";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            boughtView.DataSource = dt;
            this.boughtView.Refresh();
        }
        private void Bought_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void boughtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.boughtView.Rows[e.RowIndex];
                String selected_pid = row.Cells["PID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see property '{row.Cells["PID"].Value.ToString()}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Property_Viewer obj = new Property_Viewer(selected_pid);
                    obj.Show();
                }
            }
        }
    }
}

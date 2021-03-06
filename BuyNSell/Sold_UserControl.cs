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
    public partial class Sold_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(Login.connectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        private static Sold_UserControl _instance;
        public static Sold_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sold_UserControl();
                return _instance;
            }
        }
        public Sold_UserControl()
        {
            InitializeComponent();
        }

        public void refreshDataGridView(string uid)
        {
            con.Open();
            String syntax = $"SELECT TID,customer_UID,PID,price,date FROM [Transaction] WHERE owner_UID='{uid}'";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            soldView.DataSource = dt;
            this.soldView.Refresh();
        }
        private void Sold_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void soldView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.soldView.Rows[e.RowIndex];
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

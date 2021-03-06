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
    public partial class MyBids_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(Login.connectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        private static MyBids_UserControl _instance;
        public static MyBids_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyBids_UserControl();
                return _instance;
            }
        }
        public MyBids_UserControl()
        {
            InitializeComponent();
            refreshDataGridView(User_Details.UID);
        }
        public void refreshDataGridView(string uid)
        {
            con.Open();                                                                                                             
            String syntax = $"SELECT [Bids].PID,PropertyName,BidPrice,AskPrice FROM [Bids] ,[Property] WHERE [Bids].UID = '{uid}' and [Bids].PID= [Property].PID";
            cmd = new SqlCommand(syntax, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            myBidsView.DataSource = dt;
        }

        private void MyBids_UserControl_Load(object sender, EventArgs e)
        {
            refreshDataGridView(User_Details.UID);
        }
        private void myPropView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.myBidsView.Rows[e.RowIndex];
                String selected_pid = row.Cells["PID"].Value.ToString();
                if (MessageBox.Show($"Do you want to see property '{row.Cells["PropertyName"].Value.ToString()}'??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Property_Viewer obj = new Property_Viewer(selected_pid);
                    obj.Show();
                    refreshDataGridView(User_Details.UID);
                    this.myBidsView.Refresh();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



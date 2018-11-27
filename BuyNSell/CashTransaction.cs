using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BuyNSell
{
    class CashTransaction
    {
        SqlConnection con = new SqlConnection(Login.connectionString);
        SqlDataReader dr;
        public void addMoney(int amount,String UID)
        {
            con.Open();
            String qry1 = $"Select Cash from [User] where uid ={UID}";
            dr = new SqlCommand(qry1, con).ExecuteReader();
            dr.Read();
            int current = Convert.ToInt32(dr[0].ToString());
            dr.Close();
            String qry2 = $"Update [User] set Cash={current + amount} where uid ={UID}";
            dr = new SqlCommand(qry2, con).ExecuteReader();
            con.Close();
        }
        public Boolean removeMoney(int amount, String UID)
        {
            con.Open();
            String qry1 = $"Select Cash from [User] where uid ={UID}";
            dr = new SqlCommand(qry1, con).ExecuteReader();
            dr.Read();
            int current = Convert.ToInt32(dr[0].ToString())-amount;
            dr.Close();
            if(current<0)
            return false;
            String qry2 = $"Update [User] set Cash={current} where uid ={UID}";
            dr = new SqlCommand(qry2, con).ExecuteReader();
            con.Close();
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace All
{
    public class Connection1
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet data;
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Open();
            }
            String str = System.Configuration.ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;
            con.ConnectionString = str;
            con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataSet ExecuteQuery(string query)
        {
            try
            {
                data = new DataSet();
                OpenConnection();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandTimeout = 2000000;
                adp.SelectCommand = cmd;

                adp.Fill(data);
                CloseConnection();
                return data;
            }
            catch
            {
                CloseConnection();
                return data;
            }
        }

    }
}
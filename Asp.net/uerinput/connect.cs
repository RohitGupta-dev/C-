using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace uerinput
{
    public class connect
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter Adp = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet data;


        public void open_conection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Open();
            }
            string str = System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString;
            con.ConnectionString = str;
            con.Open();
        }
        public void close_connection()
        {
            con.Close();
        }
        public DataSet queryExecuter(string DATA)
        {
            try
            {
                data = new DataSet();
                open_conection();
                cmd.Connection = con;
                cmd.CommandText = DATA;
                cmd.CommandTimeout = 2000000;
                Adp.SelectCommand = cmd;
                Adp.Fill(data);
                close_connection();
                return data;
            }
            catch
            {
                close_connection();
                return data;
            }
        }
    }
}
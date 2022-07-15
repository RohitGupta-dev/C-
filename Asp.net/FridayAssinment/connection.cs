using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace FridayAssinment
{
    public class connection
    {
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds;

        public void fn_OpenConnection()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Open();
            }
            String str = System.Configuration.ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString;
            sqlCon.ConnectionString = str;
            sqlCon.Open();
        }

        public void fn_CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        public DataSet fn_ExecuteQuery(string query)
        {
            try
            {
                ds = new DataSet();
                fn_OpenConnection();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = query;
                sqlCmd.CommandTimeout = 2000000;
                dataAdapter.SelectCommand = sqlCmd;

                dataAdapter.Fill(ds);
                fn_CloseConnection();
                return ds;
            }
            catch
            {
                fn_CloseConnection();
                return ds;
            }
        }
    }
}
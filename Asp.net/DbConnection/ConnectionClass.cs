using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.sqlClient;

namespace DbConnection
{
    public class ConnectionClass
    {
        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet ds;

        public void openConnetion()
        {
            if (sqlConnect.State == ConnectionState.Open)
            {
                sqlConnect.Close();
            }
            String s = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            sqlConnect.ConnectionString = s;
            sqlConnect.Open();
        }
        public void closeConnection()
        {
            if (sqlConnect.State == ConnectionState.Open)
            {
                sqlConnect.Close();
            }
        }
        public DataSet executeQuery(string query)
        {
            try
            {
                ds = new DataSet();
                openConnetion();
                sqlCommand.Connection = sqlConnect;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 200000;
                sqlAdapter.SelectCommand = sqlCommand;

                sqlAdapter.Fill(ds);
                closeConnection();
                return ds;
            }
            catch
            {
                closeConnection();
                return ds;
            }
        }
    }
}

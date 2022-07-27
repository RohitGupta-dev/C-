using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace connection
{
    public class connectionDb
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds;
        

        public void connectionTODataBase()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string str = ConfigurationManager.ConnectionStrings["DBconnect"].ConnectionString;
            con.ConnectionString = str;
            con.Open();
        }
        public void CloseConnectionToDataBase()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataSet ExecuteQuery(string Query)
        {
            try
            {
                ds = new DataSet();
                connectionTODataBase();
                cmd.Connection = con;
                cmd.CommandText = Query;
                cmd.CommandTimeout = 2000000;
                adp.SelectCommand = cmd;
                adp.Fill(ds);
                CloseConnectionToDataBase();
                return ds;

            }catch(Exception err)
            {
                Console.WriteLine(err);
            return ds;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DB_Connection
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adpater = new SqlDataAdapter();
        DataSet ds; 
    
        public void connect()
        {
             if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            String s = ConfigurationManager.ConnectionStrings["DBconnect"].ConnectionString;
            con.ConnectionString = s;
            con.Open();
        }
        public void Close_connect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


           
        }
        public DataSet ExecuteQuery( string query)
        {

            try
            {
                ds = new DataSet();
                connect();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandTimeout = 200000;
                adpater.SelectCommand = cmd;
                adpater.Fill(ds);
                Close_connect();
                
            return ds;
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                return ds;
            }

        }


    }

}

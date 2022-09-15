using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Dlogic
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
        public DataSet queryExecuter(string query)
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
            catch (Exception err)
            {
                Console.WriteLine(err);
                return ds;
            }

        }


    }

    public class Insert
    {
        DataSet ds;
        Connection conn = new Connection();
        public DataSet InsertDb(object name, object email, object password, object status)
        {
            ds = new DataSet();
            ds = conn.queryExecuter("UserSingupData '" + name + "','" + email + "','" + password + "','" + status + "'");
            return ds;
        }
    }

    public class update
    {


        DataSet ds;
        Connection conn = new Connection();

        public DataSet updateDb(object Dob, object Age, object Qualification, object State, object City, object Address, object Photo, object Profile, object Email)
        {
            ds = new DataSet();
            ds = conn.queryExecuter("UserSingFullDetails '" + Dob + "','" + Age + "','" + Qualification + "','" + State + "','" + City + "','" + Address + "','" + Photo + "','" + Profile + "','" + Email + "'");

            return ds;
        }
    }


    public class login
    {
        DataSet ds;
        Connection conn = new Connection();
        public DataSet LoginDb(object username, object password)
        {
            ds = new DataSet();
            ds = conn.queryExecuter("uSERCHECK '" + username + "','" + password + "'");
            return ds;
        }

        public DataSet User_CheckDb(object username, object password, object profile)
        {
            ds = new DataSet();
            Connection conn = new Connection();
            ds = conn.queryExecuter("AdminCHECK '" + username + "','" + password + "','" + profile + "'");
            return ds;
        }

    }
    public class ShowData{
        DataSet ds;
        Connection conn = new Connection();
        public DataSet ShowDb()
        {
            ds = new DataSet();
            ds = conn.queryExecuter("AllAdmin");
            return ds;
        }

        public DataSet ShowUserDb(object email,object pwd)
        {
            ds = new DataSet();
            ds = conn.queryExecuter("UserDatacheck '"+email+"','"+pwd+"'");
            return ds;
        }

    }

}


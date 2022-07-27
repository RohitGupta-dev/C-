using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using connection;

namespace connection
{
    public class insertDetailsForEmploy
    {
        connectionDb con = new connectionDb();
        DataSet ds;
        public DataSet insert(object name, object email, object phone, object _class)
        {
            ds = new DataSet();
            ds = con.ExecuteQuery("checkData'" + name +"','"+ email+ "','" + phone+ "','" + _class + "'");
            return ds;

        }

    }
}

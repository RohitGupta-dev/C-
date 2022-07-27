using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using connection;
namespace BussinessLogics
{
    public class insert
    {
        DataSet ds;
        connection.insertDetailsForEmploy con = new insertDetailsForEmploy();
        public DataSet insertData(object name,object email,object phone,object _class)
        {
            ds = new DataSet();
            ds = con.insert(name, email, phone, _class);
            return ds;
        }
       
    }
}

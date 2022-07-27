using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnection;

namespace DbConnection
{
    public class StudentClass1
    {
        DataSet ds = new DataSet();
        ConnectionClass con = new ConnectionClass();
        public DataSet insertStudent(object Name, object Roll, object Class)
        {
            ds = new DataSet();
            ds = con.executeQuery("insertDetails '" + Name + "', '" + Roll + "', '" + Class + "' ");

            return ds;

        }
    }
}

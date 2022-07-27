using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using connectionDB;
using System.Data;
using System.Data.SqlClient;

namespace connectionDB
{
    public class StudentClass1
    {
        DataSet ds = new DataSet();
        ConnectionClass con = new ConnectionClass();
        public DataSet insertStudent(object Name, object Roll, object Class)
        {
            ds = new DataSet();
            ds = con.executeQuery("insertData '" + Name + "', '" + Roll + "', '" + Class + "' ");

            return ds;

        }
    }
}

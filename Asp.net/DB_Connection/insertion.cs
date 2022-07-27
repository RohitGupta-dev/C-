using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_Connection
{
    public class insertion
    {
        DataSet ds = new DataSet();
        Connection con = new Connection();
        public DataSet Insertion(object name,object _class ,object rollno)
        {
            ds = new DataSet();
            ds = con.ExecuteQuery("insertData '"+ name+ "','" + _class + "','" + rollno + "'");
            return ds;
        }
    }
}

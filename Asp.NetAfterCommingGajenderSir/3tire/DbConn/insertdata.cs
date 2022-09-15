using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DbConn
{
    public class insertdata
    {
        DataSet ds = new DataSet();
        dbconection.Connection con = new dbconection.Connection();
        public DataSet insertDataIntoDb(object name, object gender, object class_, object RollNo, object file)
        
        {
            con.ExecuteQuery("SaveDa '" + name+"', '"+gender+"','"+class_+"','"+RollNo+"','"+file+"'");
            return ds;

        }
    }
}

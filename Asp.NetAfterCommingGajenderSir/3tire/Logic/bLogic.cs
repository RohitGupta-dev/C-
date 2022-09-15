using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConn;

using System.Data.SqlClient;
using System.Data;
namespace Logic
{
    public class bLogic
    {
        DataSet ds = new DataSet();
        DbConn.insertdata ins = new DbConn.insertdata();
      public DataSet insertDataB(object name, object gender, object class_, object RollNo, object file)
        {
            ds = new DataSet();
          ds=  ins.insertDataIntoDb(name, gender, class_, RollNo, file);
          
            return ds;
        }

    }
}

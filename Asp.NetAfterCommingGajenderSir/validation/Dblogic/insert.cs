using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dblogic
{
    public class insert
    {
        DataSet ds = new DataSet();
        Dbclass con =new  Dblogic.Dbclass();
        public DataSet InsertINtoDb(object name,object email,object age,object pwd)
        {
            ds=con.ExecuteQuery("saveDB '"+name+ "','" + email + "','" + age + "','" + pwd + "'");

            return ds;
        }


    }
}

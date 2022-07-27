using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using connectionDB;
namespace dbBusiness
{
    public class StudentClass1
    {
        DataSet ds = new DataSet();
        //connectionDB.StudentClass1 stuDB = new DBConnectivity.StudentClass1();
        connectionDB.StudentClass1 cc = new connectionDB.StudentClass1();
        public DataSet insertStudent(object Name, object Roll, object Class)
        {
            ds = new DataSet();
            ds = cc.insertStudent(Name, Roll, Class);
            return ds;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BussinessLogic
{
    public class StudentClass1
    {
        DataSet ds = new DataSet();
        DBConnectivity.StudentClass1 stuDB = new DBConnectivity.StudentClass1();
        public DataSet insertStudent(object Name, object Roll, object Class)
        {
            ds = new DataSet();
            ds = stuDB.insertStudent(Name, Roll, Class);
            return ds;

        }
    }
}

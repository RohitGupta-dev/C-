using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DB_Connection;


namespace BussinessLogicManagement
{
    public class Insertion
    {
        DataSet ds = new DataSet();
        DB_Connection.insertion con = new DB_Connection.insertion();

        public DataSet InsertStudents(object name,object _class,object rollno)
        {
            ds = new DataSet();
            ds = con.Insertion(name,_class,rollno);

            return ds;

        }
    }
}

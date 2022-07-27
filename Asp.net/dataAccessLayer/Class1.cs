using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;




namespace dataAccessLayer
{
    public class Class1
    {

    }
    public class clsDataLayer
    {
        SqlConnection con = new SqlConnection("Data Source=192.168.1.175;Initial Catalog=tire;User ID=revclerxdb");
        public void insertdata(string name, string _class, string rollno)
        {
            SqlDataAdapter adp = new SqlDataAdapter("insert into tireItems values('" + name + "', '" + _class + "', '" + rollno + "')", con);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
        }
        public object selectData()
        {

            SqlDataAdapter adp = new SqlDataAdapter(" select * from tireItems ", con);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
    }
}
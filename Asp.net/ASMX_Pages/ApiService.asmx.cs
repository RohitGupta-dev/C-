using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using connection;
using BussinessLogics;

namespace ASMX_Pages
{
    /// <summary>
    /// Summary description for ApiService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ApiService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //[WebMethod]
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string saveIntoDb(string name, string email, string phone, string class_)
        {

            DataSet ds = new DataSet();
            insert ins = new insert();
            // ds=ins.insertData("insertDataIntoDb'"+name+"','"+email+"','"+ phone+"','"+ class_+"'");
            ds=ins.insertData(name,email,phone,class_);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return "Data save SuccessFully";
            }
            return "Hello '" + name + "' email is '" + email +"' , phoneNumber is '"+ phone+"', class is '"+ class_+"' ";
        }
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataSet showdata()
        {
            connectionDb con = new connectionDb();


            DataSet ds = new DataSet();
            insert ins = new insert();
            // ds=ins.insertData("insertDataIntoDb'"+name+"','"+email+"','"+ phone+"','"+ class_+"'");
            ds = con.ExecuteQuery("showData");
            return ds;
           
        }
    }
}

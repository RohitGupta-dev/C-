using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DB_Connection;
using BussinessLogicManagement;
using System.Data;
using System.Data.SqlClient;
namespace learning_3tire
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string  saveIntoDb(string name,string _class,string rollno)
        {
            DataSet ds=new DataSet();
            Connection con = new Connection();
            Insertion ins = new Insertion();
            ds=ins.InsertStudents(name, _class, rollno);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return "Data Save SuccessFully";

            }
            return "Some Error";
        }
       
    }
}

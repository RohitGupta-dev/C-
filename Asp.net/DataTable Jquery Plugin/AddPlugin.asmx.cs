using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Services;
using System.Web.Script.Serialization;
using dataTablesPlugin;

namespace DataTable_Jquery_Plugin
{
    /// <summary>
    /// Summary description for AddPlugin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddPlugin : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void GetStudentDetaials()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            var students = new List<Students>();
            using (var con = new SqlConnection(cs))
            {
                var cmd = new SqlCommand("showDataStudent", con) { CommandType = CommandType.StoredProcedure };
                con.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var student = new Students
                    {
                        iD = Convert.ToInt32(dr[0].ToString()),
                        firstName = dr[1].ToString(),
                        lastName = dr[2].ToString(),
                        feesPaid = Convert.ToInt32(dr[3].ToString()),
                        gender = dr[4].ToString(),
                        emailId = dr[5].ToString(),
                        telephoneNumber = dr[6].ToString(),
                        dateOfBirth = Convert.ToDateTime(dr[7].ToString())
                    };
                    students.Add(student);
                }
            }
            var js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(students));
                            }
    }
}

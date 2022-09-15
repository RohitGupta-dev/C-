using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace WebDemo
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






        [WebMethod]
        public object CheckMail(string Email)
        {
            var  p = "{name: '"+Email+"' }";
            //Email=Email + p;
            //JavaScriptSerializer javaScript = new JavaScriptSerializer();
            Email = JsonConvert.SerializeObject(p);
            return Email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogic;
using System.Data;
namespace WebApplication1
{
    public partial class ui : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            blogicClass bs = new blogicClass();
            string name1 = name.Text;
            string email1 = email.Text;
            string age1 = age.Text;
            string pwd1 = pwd.Text;
            string cpwd1 = cpwd.Text;

          ds=  bs.insertDataintoBus(name1, email1, age1, pwd1);
        }
    }
}
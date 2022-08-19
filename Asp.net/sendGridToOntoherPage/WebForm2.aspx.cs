using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sendGridToOntoherPage
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tid.Text = Request.QueryString["id"];
            tname.Text = Request.QueryString["name"];
            trollno.Text = Request.QueryString["rollno"];
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Dashbord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("welcome " + Session["user"]);
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
            }
        }
    }
}
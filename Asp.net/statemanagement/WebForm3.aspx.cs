using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagement
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Write("welcome " + Session["User"].ToString());
            }
            else
            {
                Response.Redirect("WebForm1.aspx");

            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Session["User"] = null;
                Response.Redirect("WebForm1.aspx");

            }
           
           

           

        }
    }
}
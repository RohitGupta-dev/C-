using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            //both method working in makiung session 
            Session.Add("User", user.Text);
            //Session["User"] = user.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}
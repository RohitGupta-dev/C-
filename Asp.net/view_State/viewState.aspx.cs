using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_State
{
    public partial class viewState : System.Web.UI.Page
    {
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Restore_Click(object sender, EventArgs e)
        {
            user.Text = ViewState["user"].ToString();
            pass.Text = ViewState["pass"].ToString();
        }



        protected void submit_Click(object sender, EventArgs e)
        {
            ViewState["user"] = user.Text;
            ViewState["pass"] = pass.Text;

            user.Text = string.Empty;
            pass.Text = string.Empty;
//            Response.Redirect("SecondViewForm.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudOpertion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("name")).Text;
            SqlDataSource1.InsertParameters["gender"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("gender")).Text;
            SqlDataSource1.InsertParameters["course"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("course")).Text;
            SqlDataSource1.InsertParameters["rollno"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("rollno")).Text;
     int a=   SqlDataSource1.Insert();
            if (a > 0)
            {
                 ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('data saves')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('faild to save')</script>");
            }
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient; 
namespace Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LOGIN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from signup where username=@user and password=@password";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@user", USERNAME.Text);
            cmd.Parameters.AddWithValue("@password", PASSWORD.Text);
            con.Open();
            SqlDataReader sql= cmd.ExecuteReader();
            if (sql.HasRows)
            {
                Session["user"] = USERNAME.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login successfull')</script>");
                Response.Redirect("Dashbord.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login Failed')</script>");

            }
            con.Close();
        }

 
    }
}
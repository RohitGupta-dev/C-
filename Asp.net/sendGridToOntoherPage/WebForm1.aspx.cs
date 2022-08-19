using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace sendGridToOntoherPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        void bind()
        {
            SqlConnection con = new SqlConnection(cs);
             string query = "select * from sendData";
            SqlDataAdapter adp =new SqlDataAdapter(query,con);
            DataTable ds = new DataTable();
            adp.Fill(ds);
            GridView1.DataSource=ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            Label lid = (Label)row.FindControl("lid");
            Label lname = (Label)row.FindControl("lname");
            Label lrollno = (Label)row.FindControl("lrollno");

            Response.Redirect("WebForm2.aspx?id="+lid.Text +"&name="+lname.Text +"&rollno="+ lrollno.Text+"  ");
        }
    }

   
}
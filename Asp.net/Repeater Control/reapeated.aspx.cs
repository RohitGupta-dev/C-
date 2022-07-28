using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Repeater_Control
{
    public partial class reapeated : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = getdata();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        DataTable getdata()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from repratedControl";
            SqlDataAdapter adp = new SqlDataAdapter(query,con);
            DataTable ds = new DataTable();
            adp.Fill(ds);
            return ds;
        }
    }
}
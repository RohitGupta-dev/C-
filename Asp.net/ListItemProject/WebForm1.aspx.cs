using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ListItemProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            check();
        }


        void bind()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from listitem";
            SqlDataAdapter adp = new SqlDataAdapter(query,con);
            DataTable data = new DataTable();
            adp.Fill(data);
            ListBox1.DataSource = data;
            ListBox1.DataTextField = "name";
            ListBox1.DataValueField = "id";
            ListBox1.DataBind();
        }
        void check()
        {
            if (ListBox1.SelectedIndex == -1)
            {
                Response.Write("select any item");
            }
            else
            {
                foreach (ListItem list in ListBox1.Items)
                {
                    if (list.Selected)
                    {

                        Response.Write("selext item are " + list.Text + "<br />");
                        Response.Write("selext item are " + list.Value + "<br />");
                        Response.Write("selext item are " + ListBox1.Items.IndexOf(list) + "<br />");
                        Response.Write("==============================<br>");

                    }
                    //Response.Write("selext item are " + ListBox1.SelectedItem.Text + "<br />");
                    //Response.Write("selext item are " + ListBox1.SelectedItem.Value + "<br />");
                    //Response.Write("selext item are " + ListBox1.SelectedIndex + "<br />");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace BindingDataDropDown
{
    public partial class BindingDataInDropDown : System.Web.UI.Page
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
            if (DropDownList1.SelectedValue == "-1")
            {
                Response.Write("Select Employ");
            }
            else
            {
                //adding database data into grid
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from TableDb where name=@name";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@name", DropDownList1.SelectedItem.Text);
                DataTable data = new DataTable();
                adp.Fill(data);
                 GridView1.DataSource = data;
                GridView1.DataBind();
              
       
      
               
                Label1.Text = "Data Found";
                Label1.ForeColor = Color.Green;
                Label1.Visible = true;
            }
        }
        void bind()
        {
          
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from TableDb ";
            SqlDataAdapter adp = new SqlDataAdapter(query,con);
            //adp.SelectCommand.Parameters.AddWithValue("@name",DropDownList1.SelectedItem.Text);
            DataTable data = new DataTable();
            adp.Fill(data);
            DropDownList1.DataSource = data;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataBind();
            //GridView1.DataSource = data;
            //GridView1.DataBind();
            ListItem ls = new ListItem("Select Employ", "-1");
            //DropDownList1.items.add(ls);
            ls.Selected = true;
            DropDownList1.Items.Insert(0, ls);
            //Label1.Text = "Data Found";
            //Label1.ForeColor = Color.Green;
            //Label1.Visible = true;
        }
    }
}
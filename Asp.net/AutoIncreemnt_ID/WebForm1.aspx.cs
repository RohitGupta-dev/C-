using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AutoIncreemnt_ID
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["dataConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindGrid();
                get();
            }
        }


      

        protected void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query1 = "update autoIncrementID set name=@name,rollno=@rollno where id =@id";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@rollno", rollno.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("<script>alert('updated ')</script>");
            }
            else
            {
                Response.Write("<script>alert('not updated ')</script>");

            }
            con.Close();
            id.Text = "";
            name.Text = "";
            rollno.Text = "";
            get();
            bindGrid();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query1 = "delete from autoIncrementID where id =@id";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
          
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("<script>alert('deleted ')</script>");
            }
            else
            {
                Response.Write("<script>alert('not deleted ')</script>");

            }
            con.Close();
            id.Text = "";
            name.Text = "";
            rollno.Text = "";
            get();
            bindGrid();
        }

        void get()
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "select id from autoIncrementID";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable db = new DataTable();
            adp.Fill(db);
            if (db.Rows.Count < 1)
            {
                id.Text = "1";
            }
            else
            {
                string query1 = "select max(id) from autoIncrementID";
                SqlCommand cmd = new SqlCommand(query1, con);
                con.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i = i + 1;
                id.Text = i.ToString();
            }
        }

        protected void InsertClick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query1 = "insert into autoIncrementID values(@id,@name,@rollno)";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@rollno", rollno.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("<script>alert('Data saved')</script>");
            }
            else
            {
                Response.Write("<script>alert('Data not  saved')</script>");

            }
            con.Close();
            id.Text = "";
            name.Text = "";
            rollno.Text = "";
            get();
            bindGrid();


        }
        void bindGrid()
        {
            SqlConnection con = new SqlConnection(connection);
            string query = "select * from autoIncrementID";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable db = new DataTable();
            adp.Fill(db);
            GridView1.DataSource = db;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            Label lid = (Label)row.FindControl("labelID");
            Label lname = (Label)row.FindControl("labelname");
            Label lrollno = (Label)row.FindControl("labelrollno");
            id.Text= lid.Text;
          name.Text=  lname.Text;
           rollno.Text = lrollno.Text;
        }
    }
}
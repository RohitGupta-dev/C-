using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using DB_Connection;
using BussinessLogicManagement;
namespace learning_3tire
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Connection con = new Connection();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showData();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            Insertion ins = new BussinessLogicManagement.Insertion();
            ds=ins.InsertStudents(name.Text, @class.Text, rollno.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                showData();
                Response.Write("Student Data Save Successfully");

                
            }
            name.Text = "";
            @class.Text = "";
            rollno.Text = "";
        }
        public void showData()
        {
            ds = new DataSet();
            ds = con.ExecuteQuery("ShowData");
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }
    }
}
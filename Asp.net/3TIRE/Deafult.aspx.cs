using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using connectionDB;
using dbBusiness;

namespace _3TIRE
{
    public partial class Deafult : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        ConnectionClass con = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showData();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            dbBusiness.StudentClass1 dbstu = new dbBusiness.StudentClass1();
            ds = dbstu.insertStudent(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                showData();
                Response.Write("data added successfully");
            }
        }
        public void showData()
        {
            ds = new DataSet();
            ds = con.executeQuery("showData");
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
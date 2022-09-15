using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLogic;
using System.Data;
namespace WebDemo
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        BLogic.ShowData show = new ShowData();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = show.ShowBS();
            

            //GridView1.DataSource = ds;
            //GridView1.DataBind();
        }
    }
}
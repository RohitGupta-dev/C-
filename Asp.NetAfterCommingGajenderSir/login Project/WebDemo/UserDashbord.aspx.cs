using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLogic;
namespace WebDemo
{
    public partial class UserDashbord : System.Web.UI.Page
    {
        BLogic.ShowData sh = new ShowData();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Session["name"].ToString();
            string pwd = Session["pwd"].ToString();
            ds=sh.ShowUserDb(email,pwd);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}
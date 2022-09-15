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
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //Admin check 

            DataSet ds = new DataSet();
            BLogic.login log = new login(); 
            string user = TextBox1.Text;
            string Pwd = TextBox2.Text;
            ds=log.Loginbs(user,Pwd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("Login HoGa");
                //  Response.Redirect("UserDashbord.aspx");

                string profile = "Admin";
               DataSet ds1 = new DataSet();
                ds1 = log.userCheck(user, Pwd, profile);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    Response.Redirect("AdminDashboard.aspx");
                    Response.Write("Admin Welcome ");
                }
                else
                {

                    Session["name"] = user;
                    Session["pwd"] = Pwd;
                    Response.Redirect("UserDashbord.aspx");
                    Response.Write("User Welcome ");
                }

                }
            else
            {
                Response.Write("Id PassWord Bhul GYA");
            }

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignin.aspx");
        }
    }
}
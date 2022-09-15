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
    public partial class UserSignin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = TextBox1.Text;
            string Email= TextBox2.Text;
            string pwd = TextBox3.Text;
            string Cpwd = TextBox4.Text;
            string pro = "User";
            DataSet ds = new DataSet();
            BLogic.Insert ins = new Insert();
           ds= ins.InsertBs(UserName,Email,pwd,pro);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["Name"]= TextBox1.Text; 
                Session["Email"]= TextBox2.Text; 

                Response.Redirect("UserDetails.aspx");
            }
            else
            {
                Response.Write("Sign up Failed");

            }

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }
    }
}
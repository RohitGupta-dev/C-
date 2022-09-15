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
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {


                TextBox1.Text = Session["Name"].ToString();
                TextBox2.Text = Session["Email"].ToString();
            }
            else
            {
                Response.Redirect("UserSignin.aspx");
            }
        }

       

        protected void Details_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String Name = Session["Name"].ToString();
            String Email = Session["Email"].ToString();
            //String Email = "";
            string Dob =TextBox3.Text.Trim();

            
            DateTime newdate = Convert.ToDateTime(Dob);
            DateTime Now = DateTime.Now;
            int Age = new DateTime(DateTime.Now.Subtract(newdate).Ticks).Year - 1;


            string Qualification =TextBox5.Text;
            string State =TextBox6.Text;
            string City =TextBox7.Text;
            string Address =TextBox8.Text;
            string Photo = FileUpload1.FileName;
            string Profile ="User";

            BLogic.update update = new update();
           ds= update.updatebs(Dob, Age, Qualification, State, City, Address, Photo, Profile, Email);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                Response.Write("User Data Save Failed");
            }

        }       
    }
}
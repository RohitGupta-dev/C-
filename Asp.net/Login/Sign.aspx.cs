using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Login
{
    public partial class Sign : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            string query = "insert into signup(firstname,lastname,gender,email,address,username,password,cpassword)values(@name,@lname,@gender,@email,@address,@user,@pass,@cpass)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@name", fname.Text);
            cmd.Parameters.AddWithValue("@lname", lname.Text);
            cmd.Parameters.AddWithValue("@gender", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@user", username.Text);
            cmd.Parameters.AddWithValue("@pass", password.Text);
            cmd.Parameters.AddWithValue("@cpass", cpasssword.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script","alert('sign up done username is : "+ username.Text+" password is "+password.Text+"');",true);
                clearAll();

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('falied')</script>");
            }
            con.Close();

        }
        public void clearAll()
        {
            fname.Text = lname.Text = address.Text = email.Text = username.Text = password.Text = cpasssword.Text = "";
            RadioButtonList1.ClearSelection();
        }
    }
}
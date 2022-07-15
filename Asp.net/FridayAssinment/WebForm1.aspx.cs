using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FridayAssinment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            string userName = UserName.Text;
            string userMobile = Mobile.Text;
            string userAddress = Address.Text;
            string userDesignation = Designation.Text;
            string userFatherName = FatherName.Text;
            string userEmailID = EmailID.Text;
            string userDOB = DOB.Text;
            con.fn_ExecuteQuery("insertdata'"+ userName + "', '"+ userMobile + "',  '" + userAddress + "', '" + userDesignation + "','" + userFatherName + "', '" + userEmailID + "','" + userDOB + "' ");
                    }
    }
}
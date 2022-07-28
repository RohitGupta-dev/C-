using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {



                ListItem ls = new ListItem("select City", "-1");
                ListItem ls1 = new ListItem("ROHIT", "1", false);
                ListItem ls2 = new ListItem("MOHIT", "2");
                ListItem ls3 = new ListItem("JOHIT", "3");
                ListItem ls4 = new ListItem("KOHIT", "4");
                ListItem ls5 = new ListItem("TOHIT", "5");
                DropDownList1.Items.Add(ls);
                DropDownList1.Items.Add(ls1);
                DropDownList1.Items.Add(ls2);
                DropDownList1.Items.Add(ls3);
                DropDownList1.Items.Add(ls4);
                DropDownList1.Items.Add(ls5);
                DropDownList1.Items[2].Selected = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "-1")
            {
                Response.Write("select city");
            }
            else
            {
                Response.Write("select city is" + DropDownList1.SelectedItem.Text);
                Response.Write("select  SelectedValue city is" + DropDownList1.SelectedValue);
                Response.Write("select SelectedIndex city is" + DropDownList1.SelectedIndex);
            }
        }
    }
}
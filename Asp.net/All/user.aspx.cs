using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace All
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Connection1 con = new Connection1();
            string name = TextBox1.Text;

            con.ExecuteQuery("testDataInsert '"+ name+"'");
            

        }
      
        
    }
}
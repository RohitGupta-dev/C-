﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uerinput
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            connect con = new connect();
            string Name = name.Text;
            con.queryExecuter("SendDataToprocedure'"+ name+"'");
            //Response.Write(Name);
        }
    }
}
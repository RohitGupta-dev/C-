using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logic;
namespace _3TireUi
{
    public partial class FormStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveData_Click(object sender, EventArgs e)
        {
          
            DataSet ds = new DataSet();
            string name = studentName.Text;
            string gender = StudentGender.Text;
            string RollNo = StuderntRollno.Text;
            string class_ = DropDownListClass.Text;
            string file = FileUpload1.FileName.ToString();
           string date= DateTime.Now.ToString();
          string filename=  file + "-" +date;
             bLogic l = new bLogic();
          ds= l.insertDataB(name,  gender,  class_,  RollNo, filename);
            Response.Write(ds);
           
        }
    }
}
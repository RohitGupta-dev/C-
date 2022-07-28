using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace ImageSendDb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            fill();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            
            Label1.Visible = false;
            string path = Server.MapPath("images/");
            if (FileUpload1.HasFile)
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                string extension = Path.GetExtension(filename);
                HttpPostedFile postedFile = FileUpload1.PostedFile;
                int lenght = postedFile.ContentLength;
                if (extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == ".jpeg")
                {
                    if (lenght<=1000000)//lenth must less then or equal one mb 
                    {
                        SqlConnection con = new SqlConnection(cs);
                        FileUpload1.SaveAs(path + filename);
                        string name = "images/" + filename;
                        string query = "insert into img (image_name)values(@img)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@img", name);
                        con.Open();
                       int a= cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            Label1.Text = "Inserted Successfully";
                            Label1.ForeColor = System.Drawing.Color.Green;
                            Label1.Visible = true;
                            fill();
                        }
                        else
                        {
                            Label1.Text = "Inserted Failed";
                            Label1.ForeColor = System.Drawing.Color.Red;
                            Label1.Visible = true;
                        }
                        con.Close();
                    }
                    else
                    {
                        Label1.Text = "image legth does not greater then 1mb";
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Visible = true;
                    }
                }
                else
                {
                    Label1.Text = "correct Image format";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Visible = true;
                }
                     
            }
            else
            {
                Label1.Text = "please Enter an Image";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Visible = true;
            }
        }

        void fill()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from img";
            SqlDataAdapter adp = new SqlDataAdapter(query,con);
            DataTable data = new DataTable();
            adp.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();

            Label1.Text = "";

            Label1.Visible = false;

        }

       
    }
}
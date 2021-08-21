using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace MemeMosaic1
{
    public partial class addmemes : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["email"]==null)
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string status = "pending";
            if(Session["admin"]!=null)
            {
                status = "approved";
            }
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999);
            con.Open();
            DateTime today = DateTime.Today;
            string mm = myRandomNo.ToString() + System.IO.Path.GetExtension(FileUpload1.FileName);
            string qr = "INSERT INTO memes(category,title,disc,dt,img,added_by,status) VALUES('" + DropDownList3.SelectedItem + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + today + "','" + mm + "','"+Session["email"]+"','"+status+"')";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            Label10.Text = "Meme uploaded Successfully!!";
            con.Close();
            
            
            if (FileUpload1.HasFile)

            {
                FileUpload1.SaveAs(Server.MapPath("~/uploads/" + myRandomNo.ToString() + System.IO.Path.GetExtension(FileUpload1.FileName)));
                //Label10.Text = "image uploaded..!" + FileUpload1.FileName;
            }

        }
    }
}
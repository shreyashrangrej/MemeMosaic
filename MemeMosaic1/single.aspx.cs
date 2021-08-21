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
    public partial class single : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public string Id = "", img = "", title = "", price = "";

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = MapPath("uploads/"+Session["img"].ToString());
            Response.ContentType = "image/JPEG";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + filename + "");

            Response.TransmitFile(filename);
            Response.End();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["id"];



            con.Open();
            SqlCommand X = new SqlCommand();
            X.Connection = con;
            String qr = "select * from memes where Id='" + Id + "'";
            X.CommandText = qr;
            SqlDataReader r = X.ExecuteReader();
            while (r.Read())
            {
                img = r["img"].ToString();
                title = r["title"].ToString();

                Session["img"] = img;
            }
            con.Close();
        }
    }
}
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
    public partial class confirm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public string title = "", disc = "", img = "", status = "", dt = "", ad = "";
        public int i = 0;
        public string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (Request.Form["cnf"] == "Approve")
            {
                id = Request.Form["pro"];
                con.Open();
                String qr1 = "update memes set status='approved' where Id='" + id + "'";


                SqlCommand cmd1 = new SqlCommand(qr1, con);
                cmd1.ExecuteNonQuery();
               
                con.Close();
                Response.Write("<script>alert('Approved');</script>");
            //    Response.Redirect("confirm.aspx");

            }


                con.Open();
            SqlCommand x = new SqlCommand();
            x.Connection = con;
            string qr = "select * from memes where status ='pending'";
            //  Label1.Text = qr;
            // MessageBox.Show(qr);
            x.CommandText = qr;

            SqlDataReader r = x.ExecuteReader();
            while (r.Read())
            {
                ID = (r["Id"].ToString());
                title = (r["title"].ToString());
                disc = (r["disc"].ToString());
                dt = (r["dt"].ToString());
                img = (r["img"].ToString());
                ad = (r["added_by"].ToString());
                i++;
                Session["title'" + i + "'"] = title;
                Session["disc'" + i + "'"] = disc;
                Session["dt'" + i + "'"] = dt;
                Session["img'" + i + "'"] = img;
                Session["ad'" + i + "'"] = ad;
                Session["id'" + i + "'"] = ID;
                //  Session["rate'" + i + "'"] = Request.Form["proqty"].ToString();
                //Session["qty'" + i + "'"] = DropDownList1.SelectedItem.ToString();
                //Session["i"] = i;

            }
        }
    }
}
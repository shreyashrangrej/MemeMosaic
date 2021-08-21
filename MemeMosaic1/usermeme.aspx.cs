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
    public partial class usermeme : System.Web.UI.Page
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

            if (Request.Form["cnf"] == "Delete")
            {
                id = Request.Form["pro"];
                con.Open();
                String qr1 = "delete from memes where Id='" + id + "'";


                SqlCommand cmd1 = new SqlCommand(qr1, con);
                cmd1.ExecuteNonQuery();

                con.Close();
                Response.Write("<script>alert('Deleted');</script>");
                //    Response.Redirect("confirm.aspx");

            }



            con.Open();
            SqlCommand x = new SqlCommand();
            x.Connection = con;
            string qr = "select * from memes where added_by='" + Session["user"] + "'";
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
                status = (r["status"].ToString());
                i++;
                Session["title'" + i + "'"] = title;
                Session["disc'" + i + "'"] = disc;
                Session["dt'" + i + "'"] = dt;
                Session["img'" + i + "'"] = img;
                Session["ad'" + i + "'"] = ad;
                Session["id'" + i + "'"] = ID;
                Session["status'" + i + "'"] = status;
                //  Session["rate'" + i + "'"] = Request.Form["proqty"].ToString();
                //Session["qty'" + i + "'"] = DropDownList1.SelectedItem.ToString();
                //Session["i"] = i;
            }
        }
    }
}
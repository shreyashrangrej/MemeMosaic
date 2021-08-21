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
    public partial class login : System.Web.UI.Page
    {
        String email = "", pass = "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            if (DropDownList1.SelectedItem.Text == "Admin")
            {
                string qr = "select * from adminlogin  where email='" + TextBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    email = R["email"].ToString();
                    pass = R["pass"].ToString();

                }

                if (email == TextBox1.Text && pass == TextBox2.Text)
                {
                    Session["admin"] = email.ToString();
                    Session["email"] = email.ToString();
                    Response.Redirect("adminhome.aspx");
                }
                else
                {

                    Label1.Text = "Login Failed";


                }
            }
            if (DropDownList1.SelectedItem.Text == "User")
            {
                string qr1 = "select * from register where email='" + TextBox1.Text + "'";

                SqlCommand cmd1 = new SqlCommand(qr1, con);
                SqlDataReader R1 = cmd1.ExecuteReader();

                while (R1.Read())
                {
                    email = R1["email"].ToString();
                    pass = R1["pass"].ToString();

                }

                if (email == TextBox1.Text && pass == TextBox2.Text)
                {
                    Session["email"] = email.ToString();
                    Session["user"] = email.ToString();
                    Response.Redirect("userhome.aspx");
                }
                else
                {

                    Label1.Text = "Login Failed";


                }



            }


            con.Close();


        }
    }
}
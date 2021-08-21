using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemeMosaic1
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmemes.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("confirm.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("users.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("managememes.aspx");
        }
    }
}
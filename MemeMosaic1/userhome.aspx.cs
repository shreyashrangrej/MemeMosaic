using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemeMosaic1
{
    public partial class userhome : System.Web.UI.Page
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
            Response.Redirect("usermeme.aspx");
        }
    }
}
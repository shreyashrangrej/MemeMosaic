using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace MemeMosaic1
{
    public partial class allmemes : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

               
                con.Open();
                SqlCommand x = new SqlCommand();
                x.Connection = con;
                // string qr = "select * from product ";
                // MessageBox.Show(qr);

                x.CommandText = "select * from memes where status='approved'";
                SqlDataAdapter da = new SqlDataAdapter(x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                //   Label1.Text ="abc"+ cat;
                con.Close();
            }
            catch (Exception eh)
            {
                //  Label1.Text = "error" + eh;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand x = new SqlCommand();
                x.Connection = con;
                // string qr = "select * from product ";
                // MessageBox.Show(qr);

                x.CommandText = "select * from memes where status='approved'";
                SqlDataAdapter da = new SqlDataAdapter(x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                //   Label1.Text ="abc"+ cat;
                con.Close();
            }
            catch (Exception eh)
            {
                //  Label1.Text = "error" + eh;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand x = new SqlCommand();
                x.Connection = con;
                // string qr = "select * from product ";
                // MessageBox.Show(qr);

                x.CommandText = "select * from memes where status='approved' and category='Memes'";
                SqlDataAdapter da = new SqlDataAdapter(x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                //   Label1.Text ="abc"+ cat;
                con.Close();
            }
            catch (Exception eh)
            {
                //  Label1.Text = "error" + eh;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand x = new SqlCommand();
                x.Connection = con;
                // string qr = "select * from product ";
                // MessageBox.Show(qr);

                x.CommandText = "select * from memes where status='approved' and category='News'";
                SqlDataAdapter da = new SqlDataAdapter(x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                //   Label1.Text ="abc"+ cat;
                con.Close();
            }
            catch (Exception eh)
            {
                //  Label1.Text = "error" + eh;
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand x = new SqlCommand();
                x.Connection = con;
                // string qr = "select * from product ";
                // MessageBox.Show(qr);

                x.CommandText = "select * from memes where status='approved' and category='Other'";
                SqlDataAdapter da = new SqlDataAdapter(x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                //   Label1.Text ="abc"+ cat;
                con.Close();
            }
            catch (Exception eh)
            {
                //  Label1.Text = "error" + eh;
            }
        }
    }
}
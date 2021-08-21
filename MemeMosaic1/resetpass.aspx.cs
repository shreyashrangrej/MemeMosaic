using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
namespace MemeMosaic1
{
    public partial class resetpass : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        String em = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand x = new SqlCommand();
            x.Connection = con;
            em = TextBox1.Text;
            string qr = "select * from register where email='" + TextBox1.Text + "' ";
            x.CommandText = qr;
            SqlDataReader r = x.ExecuteReader();
            String b = "";
            while (r.Read())

            {

                // a = r["Email"].ToString();
                b = r["pass"].ToString();
            }
            con.Close();
            Email("Hello Your Password is-" + b);

        }
        public void Email(string htmlString)
        {
            try
            {
                em = TextBox1.Text;
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("dhbsonicollege11@gmail.com");
                message.To.Add(new MailAddress(em));
                message.Subject = "Password Recovery from Online Hotel Booking";
                message.IsBodyHtml = true;
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("dhbsonicollege11@gmail.com", "sonicollege");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

            }
            catch (Exception)
            {
            }
        }
    }
}
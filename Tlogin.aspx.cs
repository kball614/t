using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Tlogin : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        /*if (Session.IsNewSession)
        {
             Response.Write("<Script language='JavaScript'>alert('請輸入帳密');</Script>");
        }
        else
        {
            /*Response.Cookies["login"].Value = Session["login"].ToString();
            Session["login"] = Request.Cookies["login"].Value;
            Response.Redirect("MyPage.aspx");
        }*/
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TeacherProfile where Tid = @Tid AND Tpaw = @Tpaw", cn);

        using (cn)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            sda.SelectCommand.Parameters.AddWithValue("@Tid", username);
            sda.SelectCommand.Parameters.AddWithValue("@Tpaw", password);

            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                Response.Write("alert('帳號或密碼錯誤')");
                return;
            }
        }
        Response.Cookies["login"].Value = TextBox1.Text;
        Response.Cookies["login"].Expires = DateTime.Now.AddDays(1);

        Session["login"] = Request.Cookies["login"].Value;

        Response.Redirect("Tpage.aspx");
    }


}
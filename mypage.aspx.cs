using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class mypage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session.IsNewSession)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
          SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");
            cn.Open();

            DataTable dt = new DataTable();
            string com = "SELECT * FROM StudentProfile where Sid ='" + Session["login"].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(com, cn);

            using (cn)
            {
                sda.Fill(dt);
                Label1.Text = dt.Rows[0][3].ToString();
            }
        }

    }
 #region old  
    /* protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("quiz.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("review.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("login.aspx");
    }*/
    #endregion

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("quiz.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("review.aspx");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session.Abandon();
        Response.Redirect("login.aspx");
    }
}
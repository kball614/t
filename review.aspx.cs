using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class review : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        #region old
        /*string cn = "Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cn);
        string login = Session["login"].ToString();

        DataTable dt = new DataTable();
        string com = "select ROW_NUMBER() OVER(ORDER BY Time) as 測驗編號,測驗類型=Ttype,測驗成績=Score from result where Sid='" + Session["login"].ToString() + "'";
        SqlDataAdapter sda = new SqlDataAdapter(com, connect);

        using (connect)
        {
            sda.Fill(dt);
            #region table
            Label1.Text += "<table border=1>";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Label1.Text += "<td>" + dt.Columns[i].ToString() + "</td>";
            }
            foreach (DataRow dtRow in dt.Rows)
            {
                Label1.Text += "<tr>";
                foreach (DataColumn dc in dt.Columns)
                {
                    var field1 = dtRow[dc].ToString();
                    Label1.Text += "<td>" + field1 + "</td>";
                }
                Label1.Text += "</tr>";
            }
            Label1.Text += "<br /></table>";
            #endregion
        }*/
#endregion
    }
   /* protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("mypage.aspx");
    }*/
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["GV"] = GridView1.SelectedRow.Cells[4].Text;
        Response.Redirect("reviewd.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("mypage.aspx");
    }
}
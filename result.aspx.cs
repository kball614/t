using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        decimal a=0;
        decimal b=0;
        decimal c=0;
        decimal d=0;
        string typee;
        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

        string re = "select * from Result where TestID='" + Session["testid"].ToString() + "'";
        int type = Convert.ToInt32(Session["type"].ToString());

        typee = "";
        
        switch (type)
        {
            case 1:
                typee = "字型";
                break;
            case 2:
                typee = "字義";
                break;
            case 3:
                typee = "成語";
                break;
            case 4:
                typee = "注音";
                break;
            case 5:
                typee = "綜合";
                break;
        }

        DataTable dt = new DataTable();
        SqlDataAdapter sd = new SqlDataAdapter(re, cn);
        using (cn)
        {
            sd.Fill(dt);
            Label1.Text = dt.Rows[0][3].ToString();
            Label2.Text = typee;

            #region radar
            if (type == 5)
            {
                Chart1.Visible = true;
                #region type=1
                Chart1.Visible = true;
                string c1s1 = "select count(*) from LogSheet where Ttype=1 and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt1T = new DataTable();
                SqlDataAdapter sd1T1 = new SqlDataAdapter(c1s1, cn);
                sd1T1.Fill(dt1T);
                int totalTO = Convert.ToInt32(dt1T.Rows[0][0].ToString());

                string c1s2 = "select count(*) from LogSheet where Ttype=1 and Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt1C = new DataTable();
                SqlDataAdapter sd1T2 = new SqlDataAdapter(c1s2, cn);
                sd1T2.Fill(dt1C);
                int totalTOC = Convert.ToInt32(dt1C.Rows[0][0].ToString());
                #endregion

                #region type=2
                Chart1.Visible = true;
                string c2s1 = "select count(*) from LogSheet where Ttype=2 and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt2T = new DataTable();
                SqlDataAdapter sd2T1 = new SqlDataAdapter(c2s1, cn);
                sd2T1.Fill(dt2T);
                int totalTD = Convert.ToInt32(dt2T.Rows[0][0].ToString());

                string c2s2 = "select count(*) from LogSheet where Ttype=2 and Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt2C = new DataTable();
                SqlDataAdapter sd2T2 = new SqlDataAdapter(c2s2, cn);
                sd2T2.Fill(dt2C);
                int totalTDC = Convert.ToInt32(dt2C.Rows[0][0].ToString());
                #endregion

                #region type=3
                Chart1.Visible = true;
                string c3s1 = "select count(*) from LogSheet where Ttype=3 and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt3T = new DataTable();
                SqlDataAdapter sd3T1 = new SqlDataAdapter(c3s1, cn);
                sd3T1.Fill(dt3T);
                int totalTT = Convert.ToInt32(dt3T.Rows[0][0].ToString());

                string c3s2 = "select count(*) from LogSheet where Ttype=3 and Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt3C = new DataTable();
                SqlDataAdapter sd3T2 = new SqlDataAdapter(c3s2, cn);
                sd3T2.Fill(dt3C);
                int totalTTC = Convert.ToInt32(dt3C.Rows[0][0].ToString());
                #endregion

                #region type=4
                Chart1.Visible = true;
                string c4s1 = "select count(*) from LogSheet where Ttype=4 and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt4T = new DataTable();
                SqlDataAdapter sd4T1 = new SqlDataAdapter(c4s1, cn);
                sd4T1.Fill(dt4T);
                int totalTQ = Convert.ToInt32(dt4T.Rows[0][0].ToString());

                string c4s2 = "select count(*) from LogSheet where Ttype=4 and Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
                DataTable dt4C = new DataTable();
                SqlDataAdapter sd4T2 = new SqlDataAdapter(c4s2, cn);
                sd4T2.Fill(dt4C);
                int totalTQC = Convert.ToInt32(dt4C.Rows[0][0].ToString());
                #endregion

                #region determine
                if (totalTO == 0)
                {
                    a = 0;
                }
                else
                {
                    a = Math.Round((decimal)totalTOC / totalTO, 2);
                }
                if (totalTD == 0)
                {
                    b = 0;
                }
                else
                {
                    b = Math.Round((decimal)totalTDC / totalTD, 2);
                }
                if (totalTT == 0)
                {
                    c = 0;
                }
                else
                {
                    c = Math.Round((decimal)totalTTC / totalTT, 2);
                }
                if (totalTQ == 0)
                {
                    d = 0;
                }
                else
                {
                    d = Math.Round((decimal)totalTQC / totalTQ, 2);
                }
                #endregion
                Chart1.Series[0].Points[0].SetValueY(a);
                Chart1.Series[0].Points[1].SetValueY(b);
                Chart1.Series[0].Points[2].SetValueY(c);
                Chart1.Series[0].Points[3].SetValueY(d);
                //input chart
                Chart1.ChartAreas[0].AxisY.Maximum = 1;

                //Chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
                //刻度射定
                

            }
            #endregion

            #region no radar
            else
            {
                string com1 = "select count(*) from LogSheet where Ttype="+type+" and TestID='" + Session["testid"].ToString() + "'";
                DataTable dtT = new DataTable();
                SqlDataAdapter sdT = new SqlDataAdapter(com1, cn);
                sdT.Fill(dtT);
                int totalT = Convert.ToInt32(dtT.Rows[0][0].ToString());

                string com2 = "select count(*) from LogSheet where Ttype=" + type + " and Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
                DataTable dtT2 = new DataTable();
                SqlDataAdapter sdT2 = new SqlDataAdapter(com2, cn);
                sdT2.Fill(dtT2);
                int totalC = Convert.ToInt32(dtT2.Rows[0][0].ToString());

                decimal count = Math.Round((decimal)totalC / totalT, 2);
                Label3.Text = "答對率：";
                Label4.Text = count.ToString();
            }
            #endregion



            #region table
            /*Label1.Text += "<table border=1>";
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
            Label1.Text += "<br /></table>";*/
            #endregion
        }
    }
     protected void Button1_Click(object sender, EventArgs e)
     {
         Response.Redirect("mypage.aspx");
     }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("mypage.aspx");
    }
}
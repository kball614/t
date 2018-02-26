using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class test : System.Web.UI.Page
{
    int count = 1;
    int score = 0;
    string tnosel = "";
    string t1 = "Type=1";
    string t2 = "Type=2";
    string t3 = "Type=3";
    string t4 = "Type=4";
   // SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");


    protected void Page_Init(object sender, EventArgs e)
    {


        #region old
            //int i;
            Label1.Text = "";
            Label3.Text = count.ToString();
            string Sid = Session["login"].ToString();
            int type=Convert.ToInt32(Session["type"].ToString());


            RadioButtonList1.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

           /* Random Counter = new Random(Guid.NewGuid().GetHashCode());
            string MaxNUM = "select count=count(*) from QuizBase";*/
            if(type!=5)
            {
            tnosel = "SELECT top(1)* FROM (select distinct * from dbo.QuizBase where Ttype="+type+") Orders ORDER BY NEWID()";
            }
            else
            {
            tnosel = "SELECT top(1)* FROM (select distinct * from dbo.QuizBase) Orders ORDER BY NEWID()";
            }
           /* DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(tnosel, cn);*/


            using (cn)
            {
                /*
                #region random
                sda1.Fill(dt1);
                var max = dt1.Rows[0][0].ToString();
                int num = Convert.ToInt32(max);
                i = Counter.Next(1, num - 1);
                #endregion
                */
                #region tque

                //string tque = "select * from QuizBase where Tno=" +i;
                SqlDataAdapter sda2 = new SqlDataAdapter(tnosel, cn);
                DataTable dt2 = new DataTable();

                sda2.Fill(dt2);
                Label1.Text = count.ToString()+"." + dt2.Rows[0][2].ToString();
                Label4.Text = dt2.Rows[0][7].ToString();
                #endregion

                #region sel
                //var tsel = "select Tsel1,Tsel2,Tsel3,Tsel4 from QuizBase where Tno=" + i;
                var tsel = "select Tsel1,Tsel2,Tsel3,Tsel4 from QuizBase where Tno="+dt2.Rows[0][1].ToString();
                SqlDataAdapter sda3 = new SqlDataAdapter(tsel, cn);
                DataTable dt3 = new DataTable();

                sda3.Fill(dt3);
                string[] sel = { dt3.Rows[0][0].ToString(), dt3.Rows[0][1].ToString(), dt3.Rows[0][2].ToString(), dt3.Rows[0][3].ToString() };
                foreach (string s in sel)
                {
                    RadioButtonList1.Items.Add(s);
                }
                //ans[0]=RadioButtonList1.SelectedIndex;
                //t[0]=Convert.ToInt32(dt2.Rows[0][7].ToString());
                #endregion

                #region insertForst

                DataTable dtf = new DataTable();
                string chid = Session["testid"].ToString();
                string chkid = "SELECT * FROM LogSheet WHERE TestID = '" + chid+"'";
                SqlDataAdapter sdaf = new SqlDataAdapter(chkid, cn);

                sdaf.Fill(dtf);

                if (dtf.Rows.Count == 0)
                  {
                    var trueans = dt2.Rows[0][7].ToString();
                    var i = dt2.Rows[0][1].ToString();
                    Label2.Text = chid;
                    cn.Open();
                    var logsheet = "INSERT INTO LogSheet (TestID, Tno, Tso, Tanswer, Sid, Ttype)" +
                            "Values('" + chid + "' , '" + i + "' , '" + count + "' , '" + trueans + "' , '" + Sid + "', '" + dt2.Rows[0][0] + "')";
                    SqlCommand sda4 = new SqlCommand(logsheet, cn);
                    sda4.ExecuteNonQuery();
                    cn.Close();
                     }
                /*var trueans = dt2.Rows[0][7].ToString();
                string Tids = testid + Sid;
                Label2.Text = Tids;
                cn.Open();
                var logsheet = "INSERT INTO LogSheet (TestID, Tno, Tso, Tanswer, Sid)" + 
                    "Values('"+Tids+"' , '"+i+"' , '"+count+"' , '"+trueans+"' , '"+Sid+"')";
                SqlCommand sda4= new SqlCommand(logsheet,cn);
                sda4.ExecuteNonQuery();
                cn.Close();*/
                #endregion
            }
        #endregion

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int radio = RadioButtonList1.SelectedIndex+1;

        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

        Label2.Text = radio.ToString();
        int c = Convert.ToInt32(Label3.Text);

        cn.Open();
        string upcom = "UPDATE LogSheet SET Sanswer = " + radio +
            "WHERE Sid='" + Session["login"] + "' AND TestID='" + Session["testid"] + "' AND Tso='" + c + "'";
        SqlCommand up = new SqlCommand(upcom, cn);
        up.ExecuteNonQuery();
        cn.Close();
        Label3.Text = "";
        c++;
        Label3.Text = c.ToString();
        if (c <= 10)
        {

            int i;
            int r = RadioButtonList1.SelectedIndex+1;
            Label1.Text = "";
            RadioButtonList1.Items.Clear();
            //SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

            Random Counter = new Random(Guid.NewGuid().GetHashCode());
            string MaxNUM = "select count=count(*) from QuizBase";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(MaxNUM, cn);


            using (cn)
            {/*
                #region random
                sda1.Fill(dt1);
                var max = dt1.Rows[0][0].ToString();
                int num = Convert.ToInt32(max);
                i = Counter.Next(1, num - 1);
                #endregion
                */
                #region tque

                //string tque = "select * from QuizBase where Tno=" +i;
                SqlDataAdapter sda2 = new SqlDataAdapter(tnosel, cn);
                DataTable dt2 = new DataTable();

                sda2.Fill(dt2);
                Label1.Text = c.ToString()+"." + dt2.Rows[0][2].ToString();
                Label4.Text = dt2.Rows[0][7].ToString();
                #endregion

                #region sel
                var tsel = "select Tsel1,Tsel2,Tsel3,Tsel4 from QuizBase where Tno=" + dt2.Rows[0][1].ToString();
                SqlDataAdapter sda3 = new SqlDataAdapter(tsel, cn);
                DataTable dt3 = new DataTable();

                sda3.Fill(dt3);
                string[] sel = { dt3.Rows[0][0].ToString(), dt3.Rows[0][1].ToString(), dt3.Rows[0][2].ToString(), dt3.Rows[0][3].ToString() };
                foreach (string s in sel)
                {
                    RadioButtonList1.Items.Add(s);
                }
                //ans[0]=RadioButtonList1.SelectedIndex;
                //t[0]=Convert.ToInt32(dt2.Rows[0][7].ToString());


                #endregion


               /* cn.Open();
                string upcom2 = "UPDATE LogSheet SET Tso = " + c +
                    "WHERE Sid='" + Session["login"] + "' AND TestID='" + testid + Session["login"] + "'";
                SqlCommand up2 = new SqlCommand(upcom, cn);
                up2.ExecuteNonQuery();
                cn.Close();*/
                cn.Open();
                var i2 = dt2.Rows[0][1].ToString();
                var inse = "INSERT INTO LogSheet (TestID, Tno, Tso, Tanswer, Sid, Ttype)" +
                "Values('" + Session["testid"] + "' , '" + i2 + "' , '" + c + "' , '" + dt2.Rows[0][7].ToString() + "' , '" + Session["login"] + "', '" + dt2.Rows[0][0] + "')";
                SqlCommand sda4 = new SqlCommand(inse, cn);
                sda4.ExecuteNonQuery();
                cn.Close();

                cn.Open();
                string upcom2 = "UPDATE LogSheet SET Sanswer = " + radio +
                    "WHERE Sid='" + Session["login"] + "' AND TestID='" + Session["testid"] + "' AND Tso='" + c + "'";
                SqlCommand up2 = new SqlCommand(upcom2, cn);
                up2.ExecuteNonQuery();
                cn.Close();
            }

        }
        else
        {
            DataTable dtR = new DataTable();
            string r = "select count(*) from LogSheet where Tanswer = Sanswer and TestID='" + Session["testid"].ToString() + "'";
            SqlDataAdapter sdaR = new SqlDataAdapter(r, cn);

            using (cn)
            {
             sdaR.Fill(dtR);
             var rc = dtR.Rows[0][0].ToString();
             int rci = Convert.ToInt32(rc);

            cn.Open();
            var result = "INSERT INTO Result (TestID, Sid, Score, Ttype, Time)" +
                    "Values('" + Session["testid"].ToString() + "' , '" + Session["login"].ToString() +"' , '" + rci + "','"+Session["type"].ToString()+ "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm") + "')";
            SqlCommand sda4 = new SqlCommand(result, cn);
            sda4.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("result.aspx");
            }
            
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int radio = RadioButtonList1.SelectedIndex + 1;

        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");

        using (cn)
        {
            cn.Open();
            var delete = "DELETE FROM Result WHERE TestID ='" + Session["login"]+"'";

            SqlCommand del = new SqlCommand(delete, cn);
            del.ExecuteNonQuery();
            cn.Close();
        }

        Response.Write("<script>alert('結束測驗並且不保留紀錄');location.href='mypage.aspx'; </script>");

    }




    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
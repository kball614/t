using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class reviewd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");
        string com = "select * from LogSheet where TestID='"+Session["GV"].ToString()+"'";
        using (cn)
        {
            SqlDataAdapter sda = new SqlDataAdapter(com, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (dt.Rows[i][3].ToString() != dt.Rows[i][4].ToString())
                    DropDownList1.Items[i].Attributes.Add("style", "background-color:red");
            }

            int Tso = 0;
            string quest="select * from dbo.QuizBase where Tno='"+dt.Rows[Tso][1].ToString()+"'";
            SqlDataAdapter sdaq = new SqlDataAdapter(quest, cn);
            DataTable dtq = new DataTable();
            sdaq.Fill(dtq);
            Label1.Text = dtq.Rows[0][2].ToString();

            string[] sel = { dtq.Rows[0][3].ToString(), dtq.Rows[0][4].ToString(), dtq.Rows[0][5].ToString(), dtq.Rows[0][6].ToString() };
            foreach (string s in sel)
            {
                RadioButtonList1.Items.Add(s);
            }
            string sa = dt.Rows[Tso][4].ToString();
            int sanwser=Convert.ToInt32(sa);
            RadioButtonList1.SelectedIndex = sanwser-1;

            Label2.Text = "正確答案：" + dt.Rows[Tso][3].ToString();
            //Label3.Text = Tso.ToString();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        Label2.Text = "";
        RadioButtonList1.Items.Clear();
        SqlConnection cn = new SqlConnection("Data Source=KBALL-PC\\SQLEXPRESS;Initial Catalog=JT;Integrated Security=True");
        string com = "select * from LogSheet where TestID='" + Session["GV"].ToString() + "'";
        int c = Convert.ToInt32(DropDownList1.SelectedIndex);
        int cc = c;
        Label3.Text = c.ToString();
            using (cn)
            {
                SqlDataAdapter sda = new SqlDataAdapter(com, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string quest = "select * from dbo.QuizBase where Tno='" + dt.Rows[cc][1].ToString() + "'";
                SqlDataAdapter sdaq = new SqlDataAdapter(quest, cn);
                DataTable dtq = new DataTable();
                sdaq.Fill(dtq);
                Label1.Text = dtq.Rows[0][2].ToString();

                string[] sel = { dtq.Rows[0][3].ToString(), dtq.Rows[0][4].ToString(), dtq.Rows[0][5].ToString(), dtq.Rows[0][6].ToString() };
                foreach (string s in sel)
                {
                    RadioButtonList1.Items.Add(s);
                }
                string sa = dt.Rows[c][4].ToString();
                int sanwser = Convert.ToInt32(sa);
                RadioButtonList1.SelectedIndex = sanwser - 1;

                Label2.Text = "正確答案：" + dt.Rows[cc][3].ToString();
            }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("review.aspx");
    }
}
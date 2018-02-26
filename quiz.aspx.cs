using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class quiz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int type = Convert.ToInt32(RadioButtonList1.SelectedValue.ToString());
         switch (type)
        { 
            case 1:
                Session["type"] = 1;
                break;
            case 2:
                Session["type"] = 2;
                break;
            case 3:
                Session["type"] = 3;
                break;
            case 4:
                Session["type"] = 4;
                break;
             case 5:
                Session["type"] = 5;
                break;
        }
        
        string testid = DateTime.Now.ToString("MMddHHmmss");
        Response.Cookies["testid"].Value = testid;
        Response.Cookies["testid"].Expires = DateTime.Now.AddDays(1);
        string testidS = Request.Cookies["testid"].Value + Session["login"];

        Session["testid"] = testidS.ToString();
        Response.Redirect("test.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        int type = Convert.ToInt32(RadioButtonList1.SelectedValue.ToString());
        switch (type)
        {
            case 1:
                Session["type"] = 1;
                break;
            case 2:
                Session["type"] = 2;
                break;
            case 3:
                Session["type"] = 3;
                break;
            case 4:
                Session["type"] = 4;
                break;
            case 5:
                Session["type"] = 5;
                break;
        }

        string testid = DateTime.Now.ToString("MMddHHmmss");
        Response.Cookies["testid"].Value = testid;
        Response.Cookies["testid"].Expires = DateTime.Now.AddDays(1);
        string testidS = Request.Cookies["testid"].Value + Session["login"];

        Session["testid"] = testidS.ToString();
        Response.Redirect("test.aspx");
    }
}
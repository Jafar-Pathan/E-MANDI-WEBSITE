using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_btn_Click(object sender, EventArgs e)
    {
        if ((uid_txt.Text.Equals("Admin")) && (pwd_txt.Text.Equals("Admin")))
        {
            Response.Redirect("~/Admin/Home.aspx");
        }
        else if ((uid_txt.Text.Equals("admin")) && (pwd_txt.Text.Equals("admin")))
        {
            Response.Redirect("~/Admin/Home.aspx");
        }
        else if ((uid_txt.Text.Equals("ADMIN")) && (pwd_txt.Text.Equals("ADMIN")))
        {
            Response.Redirect("~/Admin/Home.aspx");
        }
        else
        {
            msg_lbl.Text = "You've Entered Invalid Login Details. Try Again";
        }
    }
}
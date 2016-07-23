using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.state_management_demo
{
    public partial class Client_side_session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                Response.Redirect("~/Hello.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] == null)
            {
                HttpCookie cookie = new HttpCookie("username", this.username.Text);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Hello.aspx");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.state_management_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                this.usernameLabel.Text = "Hello " + Request.Cookies["username"].Value;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}
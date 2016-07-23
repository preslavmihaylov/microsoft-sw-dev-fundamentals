using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.state_management_demo
{
    public partial class Clicks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["clicks"] == null)
            {
                Session["clicks"] = 0;
            }

            this.clicksLabel.Text = Session["clicks"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["clicks"] == null)
            {
                Session["clicks"] = 0;
            }

            Session["clicks"] = (int)Session["clicks"] + 1;

            this.clicksLabel.Text = Session["clicks"].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.state_management_demo
{
    public partial class Pages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.QueryString["page"] != null)
            {
                this.pageNumberLabel.Text = "Current page is " + this.Request.QueryString["page"];
            }
            else
            {
                this.pageNumberLabel.Text = "No page selected";
            }
        }
    }
}
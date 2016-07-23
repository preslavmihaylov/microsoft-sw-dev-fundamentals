using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.state_management_demo
{
    public partial class Views : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["views"] == null)
            {
                Application.Add("views", 0);
            }

            Application["views"] = (int)Application["views"] + 1;

            this.viewsLabel.Text = Application["views"].ToString();
        }
    }
}
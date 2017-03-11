using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.page_events_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("PreInit\r\n");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Init\r\n");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Load\r\n");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("PreRender\r\n");
        }
    }
}
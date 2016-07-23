using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.page_events_demo.Startup))]
namespace _01.page_events_demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

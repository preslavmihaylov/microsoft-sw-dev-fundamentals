using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.state_management_demo.Startup))]
namespace _02.state_management_demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

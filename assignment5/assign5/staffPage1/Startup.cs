using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(staffPage1.Startup))]
namespace staffPage1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

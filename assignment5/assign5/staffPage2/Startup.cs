using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(staffPage2.Startup))]
namespace staffPage2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

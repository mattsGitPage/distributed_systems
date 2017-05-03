using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(publicPage.Startup))]
namespace publicPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

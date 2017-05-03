using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(membersPage.Startup))]
namespace membersPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tempASP.Startup))]
namespace tempASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

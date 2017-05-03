using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESTasp.Startup))]
namespace RESTasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

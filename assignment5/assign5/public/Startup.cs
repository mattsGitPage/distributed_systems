using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(public.Startup))]
namespace public
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

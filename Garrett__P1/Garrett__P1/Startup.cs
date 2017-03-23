using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garrett__P1.Startup))]
namespace Garrett__P1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

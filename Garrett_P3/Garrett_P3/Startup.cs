using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garrett_P3.Startup))]
namespace Garrett_P3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

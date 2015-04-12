using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspwebformdb.Startup))]
namespace aspwebformdb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

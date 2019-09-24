using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeMo1.Startup))]
namespace DeMo1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

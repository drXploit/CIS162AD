using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentJaxHomes.Startup))]
namespace RentJaxHomes
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

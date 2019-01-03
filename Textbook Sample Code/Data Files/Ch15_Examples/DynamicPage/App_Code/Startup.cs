using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicPage.Startup))]
namespace DynamicPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

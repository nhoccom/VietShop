using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VietShop.Web.Startup))]
namespace VietShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

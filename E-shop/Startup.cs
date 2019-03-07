using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_shop.Startup))]
namespace E_shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

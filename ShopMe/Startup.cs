using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopMe.Startup))]
namespace ShopMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

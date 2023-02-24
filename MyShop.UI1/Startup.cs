using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.UI1.Startup))]
namespace MyShop.UI1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

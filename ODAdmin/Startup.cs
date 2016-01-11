using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ODAdmin.Startup))]
namespace ODAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevopsNagpQ3.Startup))]
namespace DevopsNagpQ3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

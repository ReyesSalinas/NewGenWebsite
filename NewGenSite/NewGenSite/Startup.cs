using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewGenSite.Startup))]
namespace NewGenSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

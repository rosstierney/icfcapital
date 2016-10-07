using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(icfcapital.Startup))]
namespace icfcapital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

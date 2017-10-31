using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRAVELTECH.Startup))]
namespace TRAVELTECH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

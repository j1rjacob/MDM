using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMS.API.Startup))]
namespace DMS.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

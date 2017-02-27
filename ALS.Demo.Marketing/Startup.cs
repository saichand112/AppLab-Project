using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALS.Demo.Marketing.Startup))]
namespace ALS.Demo.Marketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

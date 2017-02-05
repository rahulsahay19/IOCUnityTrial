using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumingWCFWithConfig.Startup))]
namespace ConsumingWCFWithConfig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

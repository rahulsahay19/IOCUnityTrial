using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumingWCFUnity.Startup))]
namespace ConsumingWCFUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

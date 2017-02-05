using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOCUnityTrial.Startup))]
namespace IOCUnityTrial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

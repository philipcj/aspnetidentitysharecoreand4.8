using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Net48FrameworkApp.Startup))]
namespace Net48FrameworkApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProject.WebServer.Startup))]
namespace TestProject.WebServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

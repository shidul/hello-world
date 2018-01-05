using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helloWorld.Startup))]
namespace helloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mockbuster.Startup))]
namespace Mockbuster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

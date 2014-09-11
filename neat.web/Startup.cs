using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neat.web.Startup))]
namespace neat.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

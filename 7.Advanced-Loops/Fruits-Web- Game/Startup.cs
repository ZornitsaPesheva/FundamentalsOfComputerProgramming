using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruits_Web__Game.Startup))]
namespace Fruits_Web__Game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

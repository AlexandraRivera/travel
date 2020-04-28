using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Votacione.Startup))]
namespace Votacione
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

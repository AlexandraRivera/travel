using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemocracyA1.Startup))]
namespace DemocracyA1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

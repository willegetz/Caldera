using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caldera.Startup))]
namespace Caldera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

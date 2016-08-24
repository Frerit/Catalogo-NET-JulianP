using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServicioWEB.Startup))]
namespace ServicioWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

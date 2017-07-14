using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comercio.Piso.Web.Startup))]
namespace Comercio.Piso.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

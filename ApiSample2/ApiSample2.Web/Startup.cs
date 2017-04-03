using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiSample2.Web.Startup))]
namespace ApiSample2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

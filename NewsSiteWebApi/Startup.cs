using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsSiteWebApi.Startup))]
namespace NewsSiteWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieWithAuthenticationAug20.Startup))]
namespace MovieWithAuthenticationAug20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

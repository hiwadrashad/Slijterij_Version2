using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlijterijSjonnieLoper_version2.Startup))]
namespace SlijterijSjonnieLoper_version2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

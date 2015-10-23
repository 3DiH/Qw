using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Qw.Startup))]
namespace Qw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

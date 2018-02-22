using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONE.Startup))]
namespace ONE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

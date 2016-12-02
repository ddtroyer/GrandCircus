using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab24.Startup))]
namespace Lab24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

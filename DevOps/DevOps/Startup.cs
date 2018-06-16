using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOps.Startup))]
namespace DevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

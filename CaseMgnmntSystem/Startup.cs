using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaseMgnmntSystem.Startup))]
namespace CaseMgnmntSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

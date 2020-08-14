using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIES_Management.Startup))]
namespace GIES_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

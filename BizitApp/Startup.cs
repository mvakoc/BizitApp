using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizitApp.Startup))]
namespace BizitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

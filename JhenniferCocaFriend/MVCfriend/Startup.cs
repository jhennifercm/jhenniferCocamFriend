using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCfriend.Startup))]
namespace MVCfriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

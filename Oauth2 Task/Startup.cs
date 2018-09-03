using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oauth2_Task.Startup))]
namespace Oauth2_Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

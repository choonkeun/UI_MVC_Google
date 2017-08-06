using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_MVC_Google.Startup))]
namespace UI_MVC_Google
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMVC.Startup))]
namespace HelloMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

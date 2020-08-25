using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(foodary.Startup))]
namespace foodary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

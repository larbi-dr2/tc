using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(timechecker0.Startup))]
namespace timechecker0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

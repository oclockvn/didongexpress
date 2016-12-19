using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(didongexpress.Startup))]
namespace didongexpress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

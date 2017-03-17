using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plantr_v2.Startup))]
namespace Plantr_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

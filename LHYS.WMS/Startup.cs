using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LHYS.WMS.Startup))]
namespace LHYS.WMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

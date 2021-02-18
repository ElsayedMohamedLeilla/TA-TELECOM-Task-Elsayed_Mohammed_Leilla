using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elsayed_Mohammed_Leilla.Startup))]
namespace Elsayed_Mohammed_Leilla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

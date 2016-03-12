using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAngularEx.Startup))]
namespace MvcAngularEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualStudioDemo.Web.Startup))]
namespace VisualStudioDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

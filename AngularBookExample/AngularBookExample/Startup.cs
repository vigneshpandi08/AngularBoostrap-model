using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularBookExample.Startup))]
namespace AngularBookExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

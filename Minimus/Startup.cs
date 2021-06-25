using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Minimus.Startup))]
namespace Minimus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

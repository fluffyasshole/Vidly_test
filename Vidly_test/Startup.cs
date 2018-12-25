using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_test.Startup))]
namespace Vidly_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

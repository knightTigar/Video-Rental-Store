using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFrameworkCustomerMovie.Startup))]
namespace MVCFrameworkCustomerMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

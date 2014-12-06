using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeFindr.Startup))]
namespace BikeFindr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

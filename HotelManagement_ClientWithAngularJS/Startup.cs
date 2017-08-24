using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagement_ClientWithAngularJS.Startup))]
namespace HotelManagement_ClientWithAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

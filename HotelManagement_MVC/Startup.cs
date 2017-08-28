using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagement_MVC.Startup))]
namespace HotelManagement_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingWaste.Startup))]
namespace BookingWaste
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

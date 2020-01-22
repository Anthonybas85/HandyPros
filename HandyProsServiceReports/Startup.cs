using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandyProsServiceReports.Startup))]
namespace HandyProsServiceReports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

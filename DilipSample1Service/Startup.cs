using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DilipSample1Service.Startup))]

namespace DilipSample1Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
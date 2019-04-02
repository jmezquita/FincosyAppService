using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FiconsysAppService.Startup))]

namespace FiconsysAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
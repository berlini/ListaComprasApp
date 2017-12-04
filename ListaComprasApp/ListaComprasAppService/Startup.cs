using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ListaComprasAppService.Startup))]

namespace ListaComprasAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
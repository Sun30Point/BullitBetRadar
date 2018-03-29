using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BullitBetRadar.Startup))]
namespace BullitBetRadar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValarMorghulis.SyncUI.Startup))]
namespace ValarMorghulis.SyncUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

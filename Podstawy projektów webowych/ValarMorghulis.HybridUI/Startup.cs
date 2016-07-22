using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValarMorghulis.HybridUI.Startup))]
namespace ValarMorghulis.HybridUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

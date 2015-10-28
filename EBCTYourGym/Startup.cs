using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EBCTYourGym.Startup))]
namespace EBCTYourGym
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

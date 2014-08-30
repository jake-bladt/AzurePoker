using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzurePokerMVC.Startup))]
namespace AzurePokerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

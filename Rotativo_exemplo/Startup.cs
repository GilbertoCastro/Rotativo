using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rotativo_exemplo.Startup))]
namespace Rotativo_exemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

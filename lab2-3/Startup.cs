using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2_3.Startup))]
namespace lab2_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

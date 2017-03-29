using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LG_S3.Startup))]
namespace LG_S3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

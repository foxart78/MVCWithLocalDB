using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWithLocalDB.Startup))]
namespace MVCWithLocalDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

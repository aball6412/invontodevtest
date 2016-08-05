using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvontoDevTest.Startup))]
namespace InvontoDevTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

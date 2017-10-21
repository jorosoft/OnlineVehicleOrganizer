using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OVO.Web.Startup))]
namespace OVO.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

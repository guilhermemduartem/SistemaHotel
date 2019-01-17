using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Guilherme.Hotel.Project.Startup))]
namespace Guilherme.Hotel.Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

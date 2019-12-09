using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_v._2.Startup))]
namespace Project_v._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

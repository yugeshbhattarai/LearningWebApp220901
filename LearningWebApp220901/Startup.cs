using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningWebApp220901.Startup))]
namespace LearningWebApp220901
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

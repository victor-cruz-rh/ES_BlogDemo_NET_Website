using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogDemo.Startup))]
namespace BlogDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld.Startup))]
namespace HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {  
            //updated on 4/27/2026 3.28
            ConfigureAuth(app);
        }
    }
}

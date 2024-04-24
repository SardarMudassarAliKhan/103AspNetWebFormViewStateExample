using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_103AspNetWebFormViewStateExample.Startup))]
namespace _103AspNetWebFormViewStateExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

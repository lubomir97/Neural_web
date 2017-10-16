using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeuralNetworks.Startup))]
namespace NeuralNetworks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

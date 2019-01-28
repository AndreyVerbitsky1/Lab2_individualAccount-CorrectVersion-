using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_individualAccount_CorrectVersion_.Startup))]
namespace Lab2_individualAccount_CorrectVersion_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

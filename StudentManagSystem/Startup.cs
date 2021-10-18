using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentManagSystem.Startup))]
namespace StudentManagSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

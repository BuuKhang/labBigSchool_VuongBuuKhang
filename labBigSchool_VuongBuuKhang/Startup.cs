using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labBigSchool_VuongBuuKhang.Startup))]
namespace labBigSchool_VuongBuuKhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

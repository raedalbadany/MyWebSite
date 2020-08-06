using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWebSite.Configuration;

namespace MyWebSite.Web.Host.Startup
{
    [DependsOn(
       typeof(MyWebSiteWebCoreModule))]
    public class MyWebSiteWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyWebSiteWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWebSiteWebHostModule).GetAssembly());
        }
    }
}

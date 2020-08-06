using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWebSite.Authorization;

namespace MyWebSite
{
    [DependsOn(
        typeof(MyWebSiteCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyWebSiteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyWebSiteAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyWebSiteApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

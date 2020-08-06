using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWebSite.EntityFrameworkCore;
using MyWebSite.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyWebSite.Web.Tests
{
    [DependsOn(
        typeof(MyWebSiteWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyWebSiteWebTestModule : AbpModule
    {
        public MyWebSiteWebTestModule(MyWebSiteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWebSiteWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyWebSiteWebMvcModule).Assembly);
        }
    }
}
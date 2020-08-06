using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyWebSite.Controllers
{
    public abstract class MyWebSiteControllerBase: AbpController
    {
        protected MyWebSiteControllerBase()
        {
            LocalizationSourceName = MyWebSiteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

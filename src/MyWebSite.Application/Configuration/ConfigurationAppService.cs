using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyWebSite.Configuration.Dto;

namespace MyWebSite.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyWebSiteAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

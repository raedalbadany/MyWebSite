using System.Threading.Tasks;
using MyWebSite.Configuration.Dto;

namespace MyWebSite.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using MyWebSite.Sessions.Dto;

namespace MyWebSite.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

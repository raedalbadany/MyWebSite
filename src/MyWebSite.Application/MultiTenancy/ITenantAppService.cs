using Abp.Application.Services;
using MyWebSite.MultiTenancy.Dto;

namespace MyWebSite.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


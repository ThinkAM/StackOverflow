using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThinkAM.StackOverflow.MultiTenancy.Dto;

namespace ThinkAM.StackOverflow.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


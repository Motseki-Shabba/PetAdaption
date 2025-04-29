using Abp.Application.Services;
using PetAdaption.MultiTenancy.Dto;

namespace PetAdaption.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}


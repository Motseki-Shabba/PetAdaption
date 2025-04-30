using Abp.Application.Services;
using PetAdaption.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace PetAdaption.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}

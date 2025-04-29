using Abp.Application.Services;
using PetAdaption.Sessions.Dto;
using System.Threading.Tasks;

namespace PetAdaption.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}

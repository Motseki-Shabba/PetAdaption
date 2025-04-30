using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using PetAdaption.Users.Dto;

namespace PetAdaption.Services.AdopterService
{
    public interface IAdopterAppService : IAsyncCrudAppService<UserDto, long>
    {
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.UI;
using PetAdaption.Authorization.Users;
using PetAdaption.Users.Dto;

namespace PetAdaption.Services.AdopterService
{
    public class AdopterAppService : AsyncCrudAppService<User, UserDto, long>
    {
        private readonly UserManager _userManager;

        public AdopterAppService(IRepository<User, long> repository, UserManager userManager) : base(repository)
        {
            _userManager = userManager;
        }


        public async Task<UserDto> CreateAdopterAsync(CreateUserDto input)
        {
            // Username uniqueness check
            if (await _userManager.FindByNameAsync(input.UserName) != null)
            {
                throw new UserFriendlyException($"Username '{input.UserName}' is already taken.");
            }

            // Email uniqueness check
            if (await _userManager.FindByEmailAsync(input.EmailAddress) != null)
            {
                throw new UserFriendlyException($"Email '{input.EmailAddress}' is already in use.");
            }

            var user = new User
            {
                UserName = input.UserName,
                EmailAddress = input.EmailAddress,
                Name = input.Name,
                Surname = input.Surname,
                IsEmailConfirmed = false,
                TenantId = AbpSession.TenantId
            };

            var result = await _userManager.CreateAsync(user, input.Password);
            if (!result.Succeeded)
            {
                throw new UserFriendlyException("Could not create the user: " + result.Errors.JoinAsString(", "));
            }




            await _userManager.AddToRoleAsync(user, "ADOPTER");

            return ObjectMapper.Map<UserDto>(user);
        }

    }
}

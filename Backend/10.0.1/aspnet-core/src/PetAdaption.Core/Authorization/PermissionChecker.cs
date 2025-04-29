using Abp.Authorization;
using PetAdaption.Authorization.Roles;
using PetAdaption.Authorization.Users;

namespace PetAdaption.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}

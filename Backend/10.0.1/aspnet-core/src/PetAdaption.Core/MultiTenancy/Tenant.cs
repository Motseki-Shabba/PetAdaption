using Abp.MultiTenancy;
using PetAdaption.Authorization.Users;

namespace PetAdaption.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}

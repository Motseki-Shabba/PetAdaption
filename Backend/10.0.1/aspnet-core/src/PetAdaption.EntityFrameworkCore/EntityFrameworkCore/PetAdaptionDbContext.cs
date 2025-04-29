using Abp.Zero.EntityFrameworkCore;
using PetAdaption.Authorization.Roles;
using PetAdaption.Authorization.Users;
using PetAdaption.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace PetAdaption.EntityFrameworkCore;

public class PetAdaptionDbContext : AbpZeroDbContext<Tenant, Role, User, PetAdaptionDbContext>
{
    /* Define a DbSet for each entity of the application */

    public PetAdaptionDbContext(DbContextOptions<PetAdaptionDbContext> options)
        : base(options)
    {
    }
}

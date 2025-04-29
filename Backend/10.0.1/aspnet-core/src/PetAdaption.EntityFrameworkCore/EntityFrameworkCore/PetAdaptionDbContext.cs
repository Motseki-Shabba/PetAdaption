using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdaption.Authorization.Roles;
using PetAdaption.Authorization.Users;
using PetAdaption.Domain.Pets_Module;
using PetAdaption.MultiTenancy;

namespace PetAdaption.EntityFrameworkCore;

public class PetAdaptionDbContext : AbpZeroDbContext<Tenant, Role, User, PetAdaptionDbContext>
{
    /* Define a DbSet for each entity of the application */

    public DbSet<Pet> Pets { get; set; }
    public DbSet<PetCategory> PetCategories { get; set; }

    public PetAdaptionDbContext(DbContextOptions<PetAdaptionDbContext> options)
        : base(options)
    {
    }
}

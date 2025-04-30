using System;
using System.Linq;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        // Force all DateTime and DateTime? to be treated as UTC

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {

            foreach (var property in entityType.GetProperties()

                .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?)))

            {

                property.SetValueConverter(new Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<DateTime, DateTime>(

                    v => v.Kind == DateTimeKind.Utc ? v : v.ToUniversalTime(),

                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc)

                ));

            }

        }

    }

}

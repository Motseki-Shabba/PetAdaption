using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace PetAdaption.EntityFrameworkCore;

public static class PetAdaptionDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<PetAdaptionDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<PetAdaptionDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}

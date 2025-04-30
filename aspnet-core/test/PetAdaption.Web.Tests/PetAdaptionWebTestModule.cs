using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PetAdaption.EntityFrameworkCore;
using PetAdaption.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PetAdaption.Web.Tests;

[DependsOn(
    typeof(PetAdaptionWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class PetAdaptionWebTestModule : AbpModule
{
    public PetAdaptionWebTestModule(PetAdaptionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PetAdaptionWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(PetAdaptionWebMvcModule).Assembly);
    }
}
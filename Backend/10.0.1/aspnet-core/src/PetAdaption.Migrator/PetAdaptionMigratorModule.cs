using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PetAdaption.Configuration;
using PetAdaption.EntityFrameworkCore;
using PetAdaption.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace PetAdaption.Migrator;

[DependsOn(typeof(PetAdaptionEntityFrameworkModule))]
public class PetAdaptionMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public PetAdaptionMigratorModule(PetAdaptionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(PetAdaptionMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            PetAdaptionConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PetAdaptionMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}

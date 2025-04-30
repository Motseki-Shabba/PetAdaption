using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PetAdaption.Authorization;

namespace PetAdaption;

[DependsOn(
    typeof(PetAdaptionCoreModule),
    typeof(AbpAutoMapperModule))]
public class PetAdaptionApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<PetAdaptionAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(PetAdaptionApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}

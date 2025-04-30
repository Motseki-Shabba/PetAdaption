using Abp.Modules;
using Abp.Reflection.Extensions;
using PetAdaption.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PetAdaption.Web.Host.Startup
{
    [DependsOn(
       typeof(PetAdaptionWebCoreModule))]
    public class PetAdaptionWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PetAdaptionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PetAdaptionWebHostModule).GetAssembly());
        }
    }
}

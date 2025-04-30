using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PetAdaption.Controllers
{
    public abstract class PetAdaptionControllerBase : AbpController
    {
        protected PetAdaptionControllerBase()
        {
            LocalizationSourceName = PetAdaptionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

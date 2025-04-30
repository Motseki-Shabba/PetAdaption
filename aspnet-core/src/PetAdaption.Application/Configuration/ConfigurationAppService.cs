using Abp.Authorization;
using Abp.Runtime.Session;
using PetAdaption.Configuration.Dto;
using System.Threading.Tasks;

namespace PetAdaption.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : PetAdaptionAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}

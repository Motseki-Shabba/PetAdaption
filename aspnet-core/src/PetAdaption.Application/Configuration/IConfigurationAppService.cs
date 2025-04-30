using PetAdaption.Configuration.Dto;
using System.Threading.Tasks;

namespace PetAdaption.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}

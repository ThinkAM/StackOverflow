using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThinkAM.StackOverflow.Configuration.Dto;

namespace ThinkAM.StackOverflow.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StackOverflowAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

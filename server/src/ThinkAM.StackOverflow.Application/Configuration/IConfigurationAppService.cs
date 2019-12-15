using System.Threading.Tasks;
using ThinkAM.StackOverflow.Configuration.Dto;

namespace ThinkAM.StackOverflow.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

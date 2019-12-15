using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.StackOverflow.Authorization.Accounts.Dto;

namespace ThinkAM.StackOverflow.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

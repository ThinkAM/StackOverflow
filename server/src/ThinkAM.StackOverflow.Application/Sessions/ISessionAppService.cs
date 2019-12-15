using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.StackOverflow.Sessions.Dto;

namespace ThinkAM.StackOverflow.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

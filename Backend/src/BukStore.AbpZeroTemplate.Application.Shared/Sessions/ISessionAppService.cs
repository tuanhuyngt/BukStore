using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Sessions.Dto;

namespace BukStore.AbpZeroTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}

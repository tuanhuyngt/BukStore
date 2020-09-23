using System.Threading.Tasks;
using BukStore.AbpZeroTemplate.Sessions.Dto;

namespace BukStore.AbpZeroTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

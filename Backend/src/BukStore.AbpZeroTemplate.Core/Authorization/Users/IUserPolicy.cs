using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace BukStore.AbpZeroTemplate.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}

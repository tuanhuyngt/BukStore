using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Editions.Dto;
using BukStore.AbpZeroTemplate.MultiTenancy.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}
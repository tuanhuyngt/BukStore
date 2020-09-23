using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Configuration.Tenants.Dto;

namespace BukStore.AbpZeroTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

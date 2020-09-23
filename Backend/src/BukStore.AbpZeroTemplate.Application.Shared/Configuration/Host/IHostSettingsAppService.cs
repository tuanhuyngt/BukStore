using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Configuration.Host.Dto;

namespace BukStore.AbpZeroTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}

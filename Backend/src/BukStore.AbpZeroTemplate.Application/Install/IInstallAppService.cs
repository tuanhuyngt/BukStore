using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Install.Dto;

namespace BukStore.AbpZeroTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}
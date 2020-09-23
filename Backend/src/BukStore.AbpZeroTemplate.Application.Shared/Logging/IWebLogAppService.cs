using Abp.Application.Services;
using BukStore.AbpZeroTemplate.Dto;
using BukStore.AbpZeroTemplate.Logging.Dto;

namespace BukStore.AbpZeroTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

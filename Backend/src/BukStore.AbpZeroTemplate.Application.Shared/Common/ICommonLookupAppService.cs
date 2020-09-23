using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BukStore.AbpZeroTemplate.Common.Dto;
using BukStore.AbpZeroTemplate.Editions.Dto;

namespace BukStore.AbpZeroTemplate.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}
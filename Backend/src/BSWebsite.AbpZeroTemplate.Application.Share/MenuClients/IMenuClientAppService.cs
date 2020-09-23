using Abp.Application.Services.Dto;
using BSWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using System.Threading.Tasks;
using System;

namespace BSWebsite.AbpZeroTemplate.Application.Share.MenuClients
{
    public interface IMenuClientAppService
    {
        Task<ListResultDto<MenuClientDto>> GetMenuClientsAsync();

        Task<PagedResultDto<MenuClientListDto>> GetMenuClientsAsync(GetMenuClientInput input);

        Task<GetMenuClientOutput> GetMenuClientForEditAsync(NullableIdDto input);

        Task<MenuClientDto> CreateMenuClientAsync(CreateMenuClientInput input);

        Task<MenuClientDto> UpdateMenuClientAsync(UpdateMenuClientInput input);

        Task DeleteMenuClientAsync(EntityDto<int> input);
    }
}

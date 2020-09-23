using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BukStore.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace BukStore.AbpZeroTemplate.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

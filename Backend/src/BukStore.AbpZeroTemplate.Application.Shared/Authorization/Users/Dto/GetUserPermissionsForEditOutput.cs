using System.Collections.Generic;
using BukStore.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace BukStore.AbpZeroTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
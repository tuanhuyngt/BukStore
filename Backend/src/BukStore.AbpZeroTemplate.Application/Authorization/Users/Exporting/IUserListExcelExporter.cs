using System.Collections.Generic;
using BukStore.AbpZeroTemplate.Authorization.Users.Dto;
using BukStore.AbpZeroTemplate.Dto;

namespace BukStore.AbpZeroTemplate.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}
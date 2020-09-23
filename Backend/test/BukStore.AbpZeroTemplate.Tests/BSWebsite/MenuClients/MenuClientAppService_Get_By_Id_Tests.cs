using System.Linq;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using BukStore.AbpZeroTemplate.Authorization.Roles;
using BukStore.AbpZeroTemplate.Authorization.Users.Dto;
using BukStore.AbpZeroTemplate.MultiTenancy;
using Shouldly;
using Xunit;
using BSWebsite.AbpZeroTemplate.Core.Models;
using BSWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using Abp.Application.Services.Dto;

namespace BukStore.AbpZeroTemplate.Tests.BSWebsite.MenuClients
{
    public class MenuClientAppService_Get_By_Id_Tests : MenuClientAppServiceTestBase
    {
        [MultiTenantFact]
        public async Task Get_By_Id_Test()
        {
            LoginAsHostAdmin();
            CreateMenuClientData();
            var menuClient = await _menuClientAppService.GetMenuClientForEditAsync(new NullableIdDto() { Id = 1 });
            menuClient.MenuClient.Name.ShouldBe("menu1");
            menuClient.MenuClient.Alias.ShouldBe("trang-chu");
        }
        
    }
}

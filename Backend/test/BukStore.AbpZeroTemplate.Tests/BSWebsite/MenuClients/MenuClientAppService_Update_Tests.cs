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
    public class MenuClientAppService_Update_Tests : MenuClientAppServiceTestBase
    {
        [MultiTenantFact]
        public async Task Should_Update_Menu_Client()
        {
            LoginAsHostAdmin();
            CreateMenuClientData();
            await DeleteMenuClientAndTestAsync(1);
            await DeleteMenuClientAndTestAsync(2);
            await DeleteMenuClientAndTestAsync(3);
        }

        private async Task DeleteMenuClientAndTestAsync(int id)
        {
            //Act
            await _menuClientAppService.DeleteMenuClientAsync(
                new EntityDto<int>()
                {
                    Id = id
                });

            //Assert
            await UsingDbContextAsync(async context =>
            {
                //Get created update
                var deletedMenu = await context.MenuClients.FirstOrDefaultAsync(x => x.Id == id && x.Status);
                deletedMenu.ShouldBe(null);
            });
        }
    }
}

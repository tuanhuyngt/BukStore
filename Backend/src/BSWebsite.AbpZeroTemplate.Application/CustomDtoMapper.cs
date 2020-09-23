using AutoMapper;
using BSWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using BSWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using BSWebsite.AbpZeroTemplate.Core.Models;

namespace BSWebsite.AbpZeroTemplate.Applications
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<MenuClient, MenuClientDto>();
            configuration.CreateMap<MenuClient, MenuClientListDto>();
            configuration.CreateMap<CreateMenuClientInput, MenuClient>();
            configuration.CreateMap<UpdateMenuClientInput, MenuClient>();

            // DemoModel
            configuration.CreateMap<DemoModel, DemoModelDto>();
            configuration.CreateMap<DemoModelInput, DemoModel>();
            configuration.CreateMap<DemoModel, DemoModelInput>();
        }
    }
}
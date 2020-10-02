using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BukStore.AbpZeroTemplate.Authorization;
using BSWebsite.AbpZeroTemplate.Application;
using Author.AbpZeroTemplate.Application;
using Customer.AbpZeroTemplate.Application;

namespace BukStore.AbpZeroTemplate
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(AbpZeroTemplateCoreModule),
        typeof(BSWebsiteApplicationModule),
        typeof(AuthorApplicationModule),
        typeof(CustomerApplicationModule)
        )]
    public class AbpZeroTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateApplicationModule).GetAssembly());
        }
    }
}
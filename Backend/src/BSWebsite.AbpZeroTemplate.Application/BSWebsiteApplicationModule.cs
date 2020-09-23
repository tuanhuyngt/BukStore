using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BSWebsite.AbpZeroTemplate.Applications;
using BSWebsite.AbpZeroTemplate.Core.Authorization;

namespace BSWebsite.AbpZeroTemplate.Application
{
    public class BSWebsiteApplicationModule : AbpModule
    {
        public BSWebsiteApplicationModule() { }

        public override void Initialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<BSWebsiteAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BSWebsiteApplicationModule).GetAssembly());
        }
    }
}

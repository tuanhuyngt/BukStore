using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BSWebsite.AbpZeroTemplate.Web.Core
{
    public class BSWebsiteWebCoreModule : AbpModule
    {
        public BSWebsiteWebCoreModule() { }

        public override void Initialize()
        {
            
        }

        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BSWebsiteWebCoreModule).GetAssembly());
        }
    }
}

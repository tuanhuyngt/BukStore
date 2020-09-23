using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero;

namespace BSWebsite.AbpZeroTemplate.Application
{
    public class BSWebsiteCoreModule : AbpModule
    {
        public BSWebsiteCoreModule() { }

        public override void Initialize()
        {
        }

        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BSWebsiteCoreModule).GetAssembly());
        }
    }
}

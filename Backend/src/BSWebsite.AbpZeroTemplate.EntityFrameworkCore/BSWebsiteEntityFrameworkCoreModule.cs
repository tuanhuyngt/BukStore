using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.MultiTenancy;
using Abp.Reflection.Extensions;
using Abp.Zero;
using Abp.Zero.EntityFrameworkCore;
using Castle.MicroKernel.Registration;

namespace BSWebsite.AbpZeroTemplate.EntityFrameworkCore
{
    [DependsOn(typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class BSWebsiteEntityFrameworkCoreModule : AbpModule
    {
        public BSWebsiteEntityFrameworkCoreModule() { }

        public override void Initialize()
        {
           
        }

        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BSWebsiteEntityFrameworkCoreModule).GetAssembly());
        }
    }
}

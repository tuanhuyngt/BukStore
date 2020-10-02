using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Customer.AbpZeroTemplate.Web.Core
{
  public class CustomerWebCoreModule : AbpModule
  {
    public CustomerWebCoreModule() { }

    public override void Initialize()
    {

    }

    public override void PreInitialize()
    {
      IocManager.RegisterAssemblyByConvention(typeof(CustomerWebCoreModule).GetAssembly());
    }
  }
}

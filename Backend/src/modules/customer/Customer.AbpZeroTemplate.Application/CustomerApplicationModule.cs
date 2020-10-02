using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Customer.AbpZeroTemplate.Application
{
  public class CustomerApplicationModule : AbpModule
  {
    public CustomerApplicationModule() { }

    public override void Initialize()
    {
      Configuration.Authorization.Providers.Add<CustomerCustomerizationProvider>();
    }

    public override void PreInitialize()
    {
      IocManager.RegisterAssemblyByConvention(typeof(CustomerApplicationModule).GetAssembly());
    }
  }
}

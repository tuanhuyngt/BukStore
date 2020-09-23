using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Author.AbpZeroTemplate.Application
{
  public class AuthorApplicationModule : AbpModule
  {
    public AuthorApplicationModule() { }

    public override void Initialize()
    {
      Configuration.Authorization.Providers.Add<AuthorAuthorizationProvider>();
    }

    public override void PreInitialize()
    {
      IocManager.RegisterAssemblyByConvention(typeof(AuthorApplicationModule).GetAssembly());
    }
  }
}

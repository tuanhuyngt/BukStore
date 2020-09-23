using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Author.AbpZeroTemplate.Web.Core
{
  public class AuthorWebCoreModule : AbpModule
  {
    public AuthorWebCoreModule() { }

    public override void Initialize()
    {

    }

    public override void PreInitialize()
    {
      IocManager.RegisterAssemblyByConvention(typeof(AuthorWebCoreModule).GetAssembly());
    }
  }
}

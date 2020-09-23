using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using BukStore.AbpZeroTemplate;

namespace Author.AbpZeroTemplate.Application
{
  public class AuthorAuthorizationProvider : AuthorizationProvider
  {
    private readonly bool _isMultiTenancyEnabled;

    public AuthorAuthorizationProvider(bool isMultiTenancyEnabled)
    {
      _isMultiTenancyEnabled = isMultiTenancyEnabled;
    }

    public AuthorAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
    {
      _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
    }

    public override void SetPermissions(IPermissionDefinitionContext context)
    {
      //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

      var pages = context.GetPermissionOrNull("Pages") ?? context.CreatePermission("Pages", L("Pages"));
      var Author = pages.CreateChildPermission("Pages.Author", L("Author"));


      var author = pages.CreateChildPermission(AuthorPermissionsConst.Pages_Administration_Author, L("Author"));
      author.CreateChildPermission(AuthorPermissionsConst.Pages_Administration_Author_Insert, L("Insert"));
      author.CreateChildPermission(AuthorPermissionsConst.Pages_Administration_Author_Search, L("Search"));
      author.CreateChildPermission(AuthorPermissionsConst.Pages_Administration_Author_Update, L("Update"));
    }

    private static ILocalizableString L(string name)
    {
      return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
    }
  }
}

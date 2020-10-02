using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using BukStore.AbpZeroTemplate;

namespace Customer.AbpZeroTemplate.Application
{
  public class CustomerCustomerizationProvider : AuthorizationProvider
    {
    private readonly bool _isMultiTenancyEnabled;

    public CustomerCustomerizationProvider(bool isMultiTenancyEnabled)
    {
      _isMultiTenancyEnabled = isMultiTenancyEnabled;
    }

    public CustomerCustomerizationProvider(IMultiTenancyConfig multiTenancyConfig)
    {
      _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
    }

    public override void SetPermissions(IPermissionDefinitionContext context)
    {
      //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

      var pages = context.GetPermissionOrNull("Pages") ?? context.CreatePermission("Pages", L("Pages"));
      var Customer = pages.CreateChildPermission("Pages.Customer", L("Customer"));


      var customer = pages.CreateChildPermission(CustomerPermissionsConst.Pages_Administration_Customer, L("Customer"));
      customer.CreateChildPermission(CustomerPermissionsConst.Pages_Administration_Customer_Insert, L("Insert"));
      customer.CreateChildPermission(CustomerPermissionsConst.Pages_Administration_Customer_Search, L("Search"));
      customer.CreateChildPermission(CustomerPermissionsConst.Pages_Administration_Customer_Update, L("Update"));
    }

    private static ILocalizableString L(string name)
    {
      return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
    }
  }
}

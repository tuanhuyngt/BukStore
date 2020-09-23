using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using BukStore.AbpZeroTemplate;

namespace BSWebsite.AbpZeroTemplate.Core.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class BSWebsiteAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public BSWebsiteAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public BSWebsiteAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(BSWebsitePermissions.Pages) ?? context.CreatePermission(BSWebsitePermissions.Pages, L("Pages"));
            var gwebsite = pages.CreateChildPermission(BSWebsitePermissions.Pages_Administration_BSWebsite, L("BSWebsite"));

            var menuClients = gwebsite.CreateChildPermission(BSWebsitePermissions.Pages_Administration_MenuClient, L("MenuClient"));
            menuClients.CreateChildPermission(BSWebsitePermissions.Pages_Administration_MenuClient_Create, L("CreatingNewMenuClient"));
            menuClients.CreateChildPermission(BSWebsitePermissions.Pages_Administration_MenuClient_Edit, L("EditingMenuClient"));
            menuClients.CreateChildPermission(BSWebsitePermissions.Pages_Administration_MenuClient_Delete, L("DeletingMenuClient"));

            var demoModels = gwebsite.CreateChildPermission(BSWebsitePermissions.Pages_Administration_DemoModel, L("DemoModel"));
            demoModels.CreateChildPermission(BSWebsitePermissions.Pages_Administration_DemoModel_Create, L("CreatingNewDemoModel"));
            demoModels.CreateChildPermission(BSWebsitePermissions.Pages_Administration_DemoModel_Edit, L("EditingDemoModel"));
            demoModels.CreateChildPermission(BSWebsitePermissions.Pages_Administration_DemoModel_Delete, L("DeletingDemoModel"));
            
            var xe = gwebsite.CreateChildPermission(BSWebsitePermissions.Pages_Administration_Xe, L("Xe"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
        }
    }
}

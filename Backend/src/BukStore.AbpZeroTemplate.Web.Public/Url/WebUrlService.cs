using Abp.Dependency;
using BukStore.AbpZeroTemplate.Configuration;
using BukStore.AbpZeroTemplate.Url;
using BukStore.AbpZeroTemplate.Web.Url;

namespace BukStore.AbpZeroTemplate.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}
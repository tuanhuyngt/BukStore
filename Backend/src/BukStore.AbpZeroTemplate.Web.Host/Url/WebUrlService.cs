﻿using Abp.Dependency;
using BukStore.AbpZeroTemplate.Configuration;
using BukStore.AbpZeroTemplate.Url;

namespace BukStore.AbpZeroTemplate.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

        public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
    }
}
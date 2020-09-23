using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using BukStore.AbpZeroTemplate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;

namespace BSWebsite.AbpZeroTemplate.Application.Controllers
{
    public abstract class BSWebsiteControllerBase : AbpController
    {
        protected BSWebsiteControllerBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        protected void SetTenantIdCookie(int? tenantId)
        {
            Response.Cookies.Append(
                "Abp.TenantId",
                tenantId?.ToString(),
                new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddYears(5),
                    Path = "/"
                }
            );
        }
    }
}

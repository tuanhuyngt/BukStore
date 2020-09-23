using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.MultiTenancy;
using Abp.Runtime.Session;
using Abp.Threading;
using BukStore.AbpZeroTemplate;
using BukStore.AbpZeroTemplate.Authorization.Users;
using BukStore.AbpZeroTemplate.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Author.AbpZeroTemplate.Application
{
  /// <summary>
  /// Derive your application services from this class.
  /// </summary>
  public abstract class AuthorAppServiceBase : ApplicationService
  {

    protected virtual void CheckErrors(IdentityResult identityResult)
    {
      identityResult.CheckErrors(LocalizationManager);
    }
  }
}
﻿using System;
using System.IO;
using Abp;
using Abp.AspNetZeroCore;
using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.Organizations;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using BukStore.AbpZeroTemplate.Authorization.Roles;
using BukStore.AbpZeroTemplate.Authorization.Users;
using BukStore.AbpZeroTemplate.Configuration;
using BukStore.AbpZeroTemplate.EntityFrameworkCore;
using BukStore.AbpZeroTemplate.MultiTenancy;
using BukStore.AbpZeroTemplate.Security.Recaptcha;
using BukStore.AbpZeroTemplate.Tests.Configuration;
using BukStore.AbpZeroTemplate.Tests.DependencyInjection;
using BukStore.AbpZeroTemplate.Tests.Url;
using BukStore.AbpZeroTemplate.Tests.Web;
using BukStore.AbpZeroTemplate.Url;
using NSubstitute;

namespace BukStore.AbpZeroTemplate.Tests
{
    [DependsOn(
        typeof(AbpZeroTemplateApplicationModule),
        typeof(AbpZeroTemplateEntityFrameworkCoreModule),
        typeof(AbpTestBaseModule))]
    public class AbpZeroTemplateTestModule : AbpModule
    {
        public AbpZeroTemplateTestModule(AbpZeroTemplateEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbContextRegistration = true;
        }

        public override void PreInitialize()
        {
            var configuration = GetConfiguration();

            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
            Configuration.UnitOfWork.IsTransactional = false;

            //Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<AbpZeroDbMigrator>();

            IocManager.Register<IAppUrlService, FakeAppUrlService>();
            IocManager.Register<IWebUrlService, FakeWebUrlService>();
            IocManager.Register<IRecaptchaValidator, FakeRecaptchaValidator>();

            Configuration.ReplaceService<IAppConfigurationAccessor, TestAppConfigurationAccessor>();
            Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);

            Configuration.Modules.AspNetZero().LicenseCode = configuration["AbpZeroLicenseCode"];

            //Uncomment below line to write change logs for the entities below:
            Configuration.EntityHistory.IsEnabled = true;
            Configuration.EntityHistory.Selectors.Add("AbpZeroTemplateEntities", typeof(User), typeof(Tenant));
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
        }

        private void RegisterFakeService<TService>()
            where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }

        private static IConfigurationRoot GetConfiguration()
        {
            return AppConfigurations.Get(Directory.GetCurrentDirectory(), addUserSecrets: true);
        }
    }
}

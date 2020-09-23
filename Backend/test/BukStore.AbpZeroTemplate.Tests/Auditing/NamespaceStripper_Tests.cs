using BukStore.AbpZeroTemplate.Auditing;
using Shouldly;
using Xunit;

namespace BukStore.AbpZeroTemplate.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("BukStore.AbpZeroTemplate.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("BukStore.AbpZeroTemplate.Auditing.GenericEntityService`1[[BukStore.AbpZeroTemplate.Storage.BinaryObject, BukStore.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("BukStore.AbpZeroTemplate.Auditing.XEntityService`1[BukStore.AbpZeroTemplate.Auditing.AService`5[[BukStore.AbpZeroTemplate.Storage.BinaryObject, BukStore.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[BukStore.AbpZeroTemplate.Storage.TestObject, BukStore.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}

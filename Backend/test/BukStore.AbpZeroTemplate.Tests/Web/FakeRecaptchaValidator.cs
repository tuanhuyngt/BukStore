using System.Threading.Tasks;
using BukStore.AbpZeroTemplate.Security.Recaptcha;

namespace BukStore.AbpZeroTemplate.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

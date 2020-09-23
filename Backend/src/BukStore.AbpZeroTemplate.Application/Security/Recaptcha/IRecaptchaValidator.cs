using System.Threading.Tasks;

namespace BukStore.AbpZeroTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}
using System.Threading.Tasks;

namespace BukStore.AbpZeroTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}

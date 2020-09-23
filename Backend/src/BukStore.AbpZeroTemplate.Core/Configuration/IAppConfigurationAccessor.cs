using Microsoft.Extensions.Configuration;

namespace BukStore.AbpZeroTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

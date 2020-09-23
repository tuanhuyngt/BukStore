using System.Threading.Tasks;

namespace BukStore.AbpZeroTemplate.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
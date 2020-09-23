using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using BukStore.AbpZeroTemplate.Authorization.Users;
using BukStore.AbpZeroTemplate.MultiTenancy;

namespace BukStore.AbpZeroTemplate.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}

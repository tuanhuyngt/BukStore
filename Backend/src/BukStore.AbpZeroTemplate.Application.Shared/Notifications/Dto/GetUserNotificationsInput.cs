using Abp.Notifications;
using BukStore.AbpZeroTemplate.Dto;

namespace BukStore.AbpZeroTemplate.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}
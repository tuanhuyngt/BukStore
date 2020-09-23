using System.ComponentModel.DataAnnotations;

namespace BukStore.AbpZeroTemplate.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
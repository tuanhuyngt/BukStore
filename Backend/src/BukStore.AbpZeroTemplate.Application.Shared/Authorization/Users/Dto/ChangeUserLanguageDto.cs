using System.ComponentModel.DataAnnotations;

namespace BukStore.AbpZeroTemplate.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

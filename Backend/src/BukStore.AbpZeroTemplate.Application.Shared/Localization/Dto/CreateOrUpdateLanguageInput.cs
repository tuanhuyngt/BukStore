using System.ComponentModel.DataAnnotations;

namespace BukStore.AbpZeroTemplate.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}
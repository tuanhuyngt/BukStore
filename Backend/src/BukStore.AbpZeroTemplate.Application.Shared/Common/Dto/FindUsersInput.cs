using BukStore.AbpZeroTemplate.Dto;

namespace BukStore.AbpZeroTemplate.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}
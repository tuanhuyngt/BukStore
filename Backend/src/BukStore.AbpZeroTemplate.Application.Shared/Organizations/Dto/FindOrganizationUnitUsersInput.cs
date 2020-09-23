using BukStore.AbpZeroTemplate.Dto;

namespace BukStore.AbpZeroTemplate.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}

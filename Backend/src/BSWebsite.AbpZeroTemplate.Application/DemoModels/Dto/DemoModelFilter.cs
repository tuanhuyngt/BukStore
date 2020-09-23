using BukStore.AbpZeroTemplate.Dto;
using BSWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace BSWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto
{
    /// <summary>
    /// <model cref="DemoModel"></model>
    /// </summary>
    public class DemoModelFilter : PagedAndSortedInputDto
    {
        public int? Value { get; set; }
        public DateTime? Date { get; set; }
    }
}

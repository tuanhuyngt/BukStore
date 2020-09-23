using System.Collections.Generic;
using Abp.Application.Services.Dto;
using BukStore.AbpZeroTemplate.Editions.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
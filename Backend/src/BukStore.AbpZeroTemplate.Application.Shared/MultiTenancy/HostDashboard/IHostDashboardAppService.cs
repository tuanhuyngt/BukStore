﻿using System.Threading.Tasks;
using Abp.Application.Services;
using BukStore.AbpZeroTemplate.MultiTenancy.HostDashboard.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy.HostDashboard
{
    public interface IHostDashboardAppService : IApplicationService
    {
        Task<HostDashboardData> GetDashboardStatisticsData(GetDashboardDataInput input);

        Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input);

        Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input);
    }
}
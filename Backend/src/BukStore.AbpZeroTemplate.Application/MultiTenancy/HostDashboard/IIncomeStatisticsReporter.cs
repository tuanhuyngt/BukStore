using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BukStore.AbpZeroTemplate.MultiTenancy.HostDashboard.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}
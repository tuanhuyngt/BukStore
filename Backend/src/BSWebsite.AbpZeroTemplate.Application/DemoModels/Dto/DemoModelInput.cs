﻿using Abp.Domain.Entities;
using BSWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace BSWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto
{
    /// <summary>
    /// <model cref="DemoModel"></model>
    /// </summary>
    public class DemoModelInput : Entity<int>
    {
        public int? Value { get; set; }
        public string Info { get; set; }
        public DateTime? Date { get; set; }
    }
}
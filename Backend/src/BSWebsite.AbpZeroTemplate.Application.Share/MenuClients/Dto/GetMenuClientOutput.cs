using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using BukStore.AbpZeroTemplate.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BSWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto
{
    public class GetMenuClientOutput
    {
        public MenuClientDto MenuClient { get; set; }
        public List<ComboboxItemDto> MenuClients { get; set; }

        public GetMenuClientOutput()
        {
            MenuClients = new List<ComboboxItemDto>();
        }
    }
}

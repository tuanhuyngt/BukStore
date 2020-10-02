using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Customer.AbpZeroTemplate.Application.Share.Customer.Dto;
using Customer.AbpZeroTemplate.Web.Core.Customer;
using BukStore.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : AbpController
    {
        private readonly ICustomerAppService CustomerAppService;

        public CustomerController(ICustomerAppService CustomerAppService)
        {
            this.CustomerAppService = CustomerAppService;
        }
        [HttpPost]
        public IDictionary<string, object> CUSTOMER_Insert([FromBody]CustomerInsertDto input)
        {
            return CustomerAppService.CUSTOMER_Insert(input);
        }
     
        [HttpPost]
        public IDictionary<string, object> CUSTOMER_Del(int Ma)
        {
            return CustomerAppService.CUSTOMER_Del(Ma);
        }
   
        [HttpPost]
        public List<CustomerSearchDto> CUSTOMER_Search([FromBody]CustomerSearchDto input)
        {
            return CustomerAppService.CUSTOMER_Search(input);
        }

    }
}

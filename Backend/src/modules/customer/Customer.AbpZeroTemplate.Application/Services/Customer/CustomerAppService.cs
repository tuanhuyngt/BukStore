using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using BukStore.AbpZeroTemplate.Helpers;
using BukStore.AbpZeroTemplate.Sessions;
using Customer.AbpZeroTemplate.Application.Share.Customer.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using BukStore.AbpZeroTemplate.Sessions.Dto;

namespace Customer.AbpZeroTemplate.Web.Core.Customer
{
    public interface ICustomerAppService : IApplicationService
    {
 
        IDictionary<string, object> CUSTOMER_Insert(CustomerInsertDto input);
        IDictionary<string, object> CUSTOMER_Del(int Ma);
        List<CustomerSearchDto> CUSTOMER_Search(CustomerSearchDto input);


    }
    public class CustomerAppService : BaseService, ICustomerAppService
    {
        public CustomerAppService()
        {

        }
    
        public IDictionary<string, object> CUSTOMER_Insert(CustomerInsertDto input)
        {
            return procedureHelper.GetData<dynamic>("CUSTOMER_Insert", input).FirstOrDefault();
        }

        public IDictionary<string, object> CUSTOMER_Del(int Ma)
        {
            return procedureHelper.GetData<dynamic>("CUSTOMER_Del", new
            {
                Ma = Ma
            }).FirstOrDefault();
        }
        public List<CustomerSearchDto> CUSTOMER_Search(CustomerSearchDto input)
        {
            return procedureHelper.GetData<CustomerSearchDto>("CUSTOMER_Search", input);
        }
    
    }
}

using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using BukStore.AbpZeroTemplate.MultiTenancy.Accounting.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}

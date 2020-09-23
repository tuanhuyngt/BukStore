using BukStore.AbpZeroTemplate.Editions.Dto;

namespace BukStore.AbpZeroTemplate.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }
    }
}

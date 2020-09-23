using Newtonsoft.Json;

namespace BukStore.AbpZeroTemplate.MultiTenancy.Payments.Paypal
{
    public class PayPalAmount
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

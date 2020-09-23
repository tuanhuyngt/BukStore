using Newtonsoft.Json;

namespace BukStore.AbpZeroTemplate.MultiTenancy.Payments.Paypal
{
    public class PayPalAccessTokenResult
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
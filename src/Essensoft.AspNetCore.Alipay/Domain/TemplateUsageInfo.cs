using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// TemplateUsageInfo Data Structure.
    /// </summary>
    public class TemplateUsageInfo : AlipayObject
    {
        /// <summary>
        /// 商家小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}

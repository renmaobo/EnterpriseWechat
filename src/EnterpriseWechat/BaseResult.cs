using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat
{
    /// <summary>
    /// base response result
    /// </summary>
    public class BaseResult
    {
        /// <summary>
        /// response result status code
        /// </summary>
        [JsonProperty("errcode")]
        public ResultStatusType ErrorCode { get; set; }

        /// <summary>
        ///  response result message describe
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }
    }
}

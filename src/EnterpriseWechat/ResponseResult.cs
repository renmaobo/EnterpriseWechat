using EnterpriseWechat.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseWechat
{
    /// <summary>
    /// base response result
    /// </summary>
    public class ResponseResult
    {
        public ResponseResult() { }

        public ResponseResult(ResultCode code, string msg)
        {
            this.ErrorCode = code;
            this.ErrorMessage = msg;
        }

        /// <summary>
        /// response result status code
        /// </summary>
        [JsonProperty("errcode")]
        public ResultCode ErrorCode { get; set; }

        /// <summary>
        ///  response result message describe
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }
    }
}

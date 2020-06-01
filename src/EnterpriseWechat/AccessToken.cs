using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace EnterpriseWechat
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessToken : ResponseResult
    {
        public AccessToken() { }

        /// <summary>
        /// add enterprise setting
        /// </summary>
        /// <param name="corpid">enterprise id</param>
        /// <param name="corpsecret">enterprise application secret code</param>
        private void AddSetting(string corpid, string corpsecret)
        {
            this.CorpId = corpid;
            this.CorpSecret = corpsecret;
        }

        /// <summary>
        /// enterprise id
        /// </summary>
        protected string CorpId { get; private set; }

        /// <summary>
        /// enterprise application secret code
        /// </summary>
        protected string CorpSecret { get; private set; }

        /// <summary>
        /// get accesstoken
        /// </summary>
        /// <param name="corpid">enterprise id</param>
        /// <param name="corpsecret">enterprise application secret code</param>
        /// <returns></returns>
        public static AccessToken GetAccessToken(string corpid, string corpsecret)
        {
            string requestUrl = $"{ShareSetting.EnterpriseWechat_DomainUrl}/cgi-bin/gettoken?corpid={corpid}&corpsecret={corpsecret}";

            AccessToken accessToken = requestUrl.HttpGet<AccessToken>();
            accessToken.AddSetting(corpid, corpsecret);

            return accessToken;
        }
    }
}

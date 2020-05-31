using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace EnterpriseWechat
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessToken : BaseResult
    {
        public AccessToken() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpid">enterprise id</param>
        /// <param name="corpsecret">enterprise application secret code</param>
        private AccessToken(string corpid, string corpsecret)
        {
            this.CorpId = corpid;
            this.Corpsecret = corpsecret;
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
        public AccessToken GetAccessToken(string corpid, string corpsecret)
        {
            AccessToken accessToken = new AccessToken(corpid, corpsecret);

            string requestUrl = $"{ShareSetting.EnterpriseWechat_DomainUrl}/cgi-bin/gettoken?corpid={corpid}&corpsecret={corpsecret}";

            requestUrl.HttpGet<AccessToken>();

            return accessToken;
        }
    }
}

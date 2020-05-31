using System;
using Xunit;

namespace EnterpriseWechat.XUnitTest
{
    /// <summary>
    /// test accesstoken
    /// </summary>
    public class TestAccessToken
    {
        [Fact]
        public void Test()
        {
            AccessToken accessToken = AccessToken.GetAccessToken(EnterpriseSetting.CorpId, EnterpriseSetting.ApplicationSecret);
            Assert.Equal(accessToken.ErrorCode, ResultStatusType.Success);
        }
    }
}

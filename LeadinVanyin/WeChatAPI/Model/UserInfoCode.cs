using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatAPI.Model
{
    public class UserInfoCode
    {
        /// <summary>
        /// 网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
        /// </summary>
        public string Access_Token { set; get; }

        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒）
        /// </summary>
        public string Expires_In { set; get; }

        /// <summary>
        /// 用户刷新access_token
        /// </summary>
        public string Refresh_Token { set; get; }

        /// <summary>
        /// 用户唯一标识，请注意，在未关注公众号时，用户访问公众号的网页，也会产生一个用户和公众号唯一的OpenID
        /// </summary>
        public string OpenId { set; get; }

        /// <summary>
        /// 用户授权的作用域，使用逗号（,）分隔
        /// </summary>
        public string Scope { set; get; }

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>
        public string Unionid { set; get; }
    }
}

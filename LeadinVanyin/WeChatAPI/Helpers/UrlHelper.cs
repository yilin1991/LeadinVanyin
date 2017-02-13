using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatAPI.Helpers
{
    public struct UrlHelper
    {
        /// <summary>
        /// 获取access token
        /// </summary>
        public const string GetAccessToken = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";

        /// <summary>
        /// 获取用户基本信息 
        /// </summary>
        public const string GetUserInfoToken = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN";

        /// <summary>
        /// 获取关注者列表
        /// </summary>
        public const string GetFocusUsers = "https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid={1}";

        /// <summary>
        /// 发送消息
        /// </summary>
        public const string SendMessage = "https://api.weixin.qq.com/cgi-bin/message/custom/send?access_token={0}";


        /// <summary>
        /// 创建自定义菜单
        /// </summary>
        public const string CreateMenu = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";


        /// <summary>
        /// 删除自定义菜单
        /// </summary>
        public const string DeleteMenu = "https://api.weixin.qq.com/cgi-bin/menu/delete?access_token={0}";



        #region 网页授权

        /// <summary>
        /// 用户授权，获取code
        /// </summary>

        public const string GetCode = "https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type={2}&scope={3}&state={4}#wechat_redirect";

        /// <summary>
        /// 通过code换取网页授权access_token
        /// </summary>
        public const string GetCodeAccess_token = "https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type={3}";

        /// <summary>
        /// 刷新access_token
        /// </summary>
        public const string RefreshCodeAccess_Token = "https://api.weixin.qq.com/sns/oauth2/refresh_token?appid={0}&grant_type={1}&refresh_token={2}";

        /// <summary>
        /// 拉取用户信息(需scope为 snsapi_userinfo)
        /// </summary>
        public const string GetCodeUserInfo = "https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}&lang={2}";

        /// <summary>
        /// 检验授权凭证（access_token）是否有效
        /// </summary>
        public const string CheckCodeAccess_Token = "https://api.weixin.qq.com/sns/auth?access_token=ACCESS_TOKEN&openid=OPENID";




        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatAPI.Model
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。
        /// </summary> 
        public string subscribe { set; get; }
        /// <summary>
        /// 用户的标识，对当前公众号唯一
        /// </summary> 
        public string openid { set; get; }
        /// <summary>
        /// 用户的昵称
        /// </summary> 
        public string nickname { set; get; }
        /// <summary>
        /// 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary> 
        public string sex { set; get; }
        /// <summary>
        /// 用户的语言，简体中文为zh_CN
        /// </summary> 
        public string language { set; get; }
        /// <summary>
        /// 用户所在城市
        /// </summary> 
        public string city { set; get; }
        /// <summary>
        /// 用户所在省份
        /// </summary> 
        public string province { set; get; }
        /// <summary>
        /// 用户所在国家
        /// </summary> 
        public string country { set; get; }
        /// <summary>
        /// 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空
        /// </summary> 
        public string headimgurl { set; get; }
        /// <summary>
        /// 用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间
        /// </summary> 
        public string subscribe_time { set; get; }
    }

    /// <summary>
    /// 关注用户列表
    /// </summary>
    public class FoucsListData
    {
        /// <summary>
        /// 关注用户总数
        /// </summary>
        public string Total { get; set; }
        /// <summary>
        /// 当前拉取用户数量
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// 列表数据
        /// </summary>
        public OpenIdListData Data { get; set; }
        /// <summary>
        /// 最后一个OpenId
        /// </summary>
        public string Next_OpenId { get; set; }
    }

    /// <summary>
    /// 关注用户OpenId列表
    /// </summary>
    public class OpenIdListData
    {
        /// <summary>
        /// OPENID的列表
        /// </summary>
        public List<string> openid { get; set; }
    }

    /// <summary>
    /// 获取用户地理位置
    /// </summary>
    public class UsersLocation
    {
        /// <summary>
        /// 开发者微信号
        /// </summary>
        public string ToUserName { get; set; }
        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary>
        public string FromUserName { get; set; }
        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 消息类型，event
        /// </summary>
        public string MsgType { get; set; }
        /// <summary>
        /// 事件类型，LOCATION
        /// </summary>
        public string Event { get; set; }
        /// <summary>
        /// 地理位置纬度
        /// </summary>
        public string Latitude { get; set; }
        /// <summary>
        /// 地理位置经度
        /// </summary>
        public string Longitude { get; set; }
        /// <summary>
        /// 地理位置精度
        /// </summary>
        public string Precision { get; set; }
    }
}

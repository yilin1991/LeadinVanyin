using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatAPI.Model
{ 

        /// <summary>
        /// 公众号的全局唯一票据
        /// </summary>
        public class AccessToken
        {
            /// <summary>
            /// 获取到的凭证
            /// </summary>
            public string Access_Token { get; set; }
            /// <summary>
            /// 凭证有效时间，单位：秒
            /// </summary>
            public string Expires_In { get; set; }
        }


        /// <summary>
        /// 自定义菜单返回说明
        /// </summary>
        public class ErrorMessage
        {
            /// <summary>
            /// 错误码 
            /// </summary>
            public string ErrCode { get; set; }

            /// <summary>
            /// 错误消息
            /// </summary>
            public string ErrMsg { get; set; }
        }
    
}

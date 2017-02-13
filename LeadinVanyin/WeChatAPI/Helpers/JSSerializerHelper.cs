using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace WeChatAPI.Helpers
{
   public  class JSSerializerHelper
    {
        /// <summary>
        /// 将字符串转换成指定对象
        /// </summary>
        /// <typeparam name="T">转换类型</typeparam>
        /// <param name="data">字符串</param>
        /// <returns></returns>
        public static T StringToObject<T>(string data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return (T)js.Deserialize<T>(data);

        }
    }
}

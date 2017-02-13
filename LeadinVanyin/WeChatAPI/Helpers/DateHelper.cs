using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace WeChatAPI.Helpers
{
    public class DateHelper
    {

        /// <summary>
        /// 将指定时间转化成长整形的数据
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static int DateToInt(DateTime dateTime)
        {
            var str = DateTime.Parse(dateTime.ToString(CultureInfo.InvariantCulture)).Subtract(TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).Ticks.ToString(CultureInfo.InvariantCulture);
            return Convert.ToInt32(str.Substring(0, str.Length - 7));
        }


        /// <summary>
        /// 将长整形的数据转化成正常dateTime类型
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime IntToDate(int date)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).Add(new TimeSpan(long.Parse(date + "0000000")));
        }
    }
}

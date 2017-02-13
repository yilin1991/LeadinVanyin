using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WeChatAPI.Helpers
{
    public class HttpHelper
    {

        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="postData"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Post(string postData, string url)
        {
            //创建一个HTTP请求
            WebRequest request = WebRequest.Create(url);
            //设置POST请求
            request.Method = "POST";
            //将数据字符串转化成数组
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //请求数据内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            //请求数据长度
            request.ContentLength = byteArray.Length;
            //创建请求数据流
            Stream dataStream = request.GetRequestStream();
            //写入数据
            dataStream.Write(byteArray, 0, byteArray.Length);
            //关闭数据流
            dataStream.Close();
            //创建一个HTTP应答
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFormServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFormServer;
        }

        public static string Get(string url)
        {
            //创建一个HTTP请求
            WebRequest request = WebRequest.Create(url);
            //设置POST请求
            request.Method = "GET";
            //请求数据内容类型
            request.ContentType = "application/json";
            //创建一个HTTP应答
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFormServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFormServer;
        }

        /// <summary>
        /// 获取传入的数据
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string GetRequest(HttpContext content)
        {
            Stream stream = content.Request.InputStream;
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }
    }
}

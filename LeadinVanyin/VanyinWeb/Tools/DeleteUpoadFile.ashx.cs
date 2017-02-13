using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;


namespace UploadFiled.Tools
{
    /// <summary>
    /// DeleteUpoadFile 的摘要说明
    /// </summary>
    public class DeleteUpoadFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
          

            SortedList<string, object> values = new SortedList<string, object>();
            JavaScriptSerializer js = new JavaScriptSerializer();


            string delfile = context.Request.Params["delfile"];

            //删除已存在的文件
            if (!string.IsNullOrEmpty(delfile))
            {
                string _filename = GetMapPath(delfile);
                if (!File.Exists(_filename))
                {
                    values.Add("msg", 0);
                    values.Add("mbox", "要删除" + delfile + "的文件不存在！");
                    context.Response.Write(js.Serialize(values));
                    return;
                }
                File.Delete(_filename);
            }

            values.Add("msg", 1);
            values.Add("mbox", delfile+"删除成功！");


            context.Response.Write(js.Serialize(values));
        }


        /// <summary>
        /// 获得当前绝对路径
        /// </summary>
        /// <param name="strPath">指定的路径</param>
        /// <returns>绝对路径</returns>
        public string GetMapPath(string strPath)
        {
            if (strPath.ToLower().StartsWith("http://"))
            {
                return strPath;
            }
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(strPath);
            }
            else //非web程序引用
            {
                strPath = strPath.Replace("/", "\\");
                if (strPath.StartsWith("\\"))
                {
                    strPath = strPath.Substring(strPath.IndexOf('\\', 1)).TrimStart('\\');
                }
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
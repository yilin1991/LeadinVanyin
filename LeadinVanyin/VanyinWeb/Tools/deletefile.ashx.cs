using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LeadinCms.Tools
{
    /// <summary>
    /// deletefile 的摘要说明
    /// </summary>
    public class deletefile : IHttpHandler
    {
        protected string ReturnString = "0";
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                string _FileName = context.Request.QueryString["file"];
                string _Type = context.Request.QueryString["type"];
                try
                {
                    if (!String.IsNullOrEmpty(_FileName))
                    {
                        if (File.Exists(context.Server.MapPath(_FileName)))
                        {
                            File.Delete(context.Server.MapPath(_FileName));
                            ReturnString = "1";
                        }
                        else
                        {
                            ReturnString = "2";
                        }
                    }
                }
                catch { }
                context.Response.Write(ReturnString + "," + _Type);
            }
            catch
            {
                context.Response.ContentType = "text/html";
                context.Response.Write(ReturnString);
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
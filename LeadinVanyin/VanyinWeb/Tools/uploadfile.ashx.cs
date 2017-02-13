using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LeadinCms.Tools
{
    /// <summary>
    /// uploadfile 的摘要说明
    /// </summary>
    public class uploadfile : IHttpHandler
    {
        protected string ReturnString = "";
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpPostedFile file = context.Request.Files["FileData"];
            string uploadpath = HttpContext.Current.Server.MapPath("/UplaodFileds/");

            string fileExtension = System.IO.Path.GetExtension(file.FileName);
            string _NewFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + fileExtension;

            string _Folder = DateTime.Now.ToString("yyyyMMdd");
            string _NewPath = uploadpath + _Folder + "\\";

            if (file != null)
            {
                if (!Directory.Exists(_NewPath))
                {
                    Directory.CreateDirectory(_NewPath);
                } 
                file.SaveAs(_NewPath + _NewFileName);
                ReturnString = "/UplaodFileds/" + _Folder + "/" + _NewFileName;
            }
            context.Response.Write(ReturnString);
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
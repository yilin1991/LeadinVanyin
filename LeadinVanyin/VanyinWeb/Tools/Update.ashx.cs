using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LitJson;
using System.IO;

namespace LeadinWeb.Tools
{
    /// <summary>
    /// Update 的摘要说明
    /// </summary>
    public class Update : IHttpHandler
    {
        protected string ReturnString = "";
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string fileid = context.Request["fileid"].ToString();
            string txtid = context.Request["txtid"].ToString();

            HttpPostedFile file = context.Request.Files[fileid];
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
            }

            JsonData data = new JsonData();

            data["txtName"] = txtid;
            data["filePath"] = "/UplaodFileds/" + _Folder + "/" + _NewFileName;



            context.Response.Write(data.ToJson());
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
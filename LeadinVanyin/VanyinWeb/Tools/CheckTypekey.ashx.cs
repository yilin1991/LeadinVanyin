using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace LeadinWeb.Tools
{
    /// <summary>
    /// CheckTypekey 的摘要说明
    /// </summary>
    public class CheckTypekey : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            if (Leadin.Common.Utils.GetCookie("designtypestate") == "edit")
            {
                context.Response.Write("y");
            }
            else
            {

                Leadin.BLL.DesignTemplateType bll = new Leadin.BLL.DesignTemplateType();

                DataSet ds = bll.GetList("TypeKey='" + context.Request["param"].ToString() + "'");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("关键字重复");
                }

                else
                {
                    context.Response.Write("y");
                }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LitJson;


namespace LeadinWeb.Tools
{
    /// <summary>
    /// DesignTypeChange 的摘要说明
    /// </summary>
    public class DesignTypeChange : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Leadin.BLL.DesignTemplateType bll = new Leadin.BLL.DesignTemplateType();

            string typeid=context.Request["typeid"].ToString();

            JsonData jd=new JsonData();

            Leadin.Model.DesignTemplateType model = bll.GetModel(int.Parse(typeid));

            jd["cycle"] = model.Cycle;
            jd["price"] = model.Price;

            context.Response.Write(jd.ToJson());
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
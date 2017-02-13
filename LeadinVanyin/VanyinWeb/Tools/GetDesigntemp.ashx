<%@ WebHandler Language="C#" Class="GetDesigntemp" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;

public class GetDesigntemp : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        context.Response.ContentType = "text/plain";

        Leadin.BLL.DesignTemplate bll = new Leadin.BLL.DesignTemplate();
        Dictionary<string, object> values = new Dictionary<string, object>();
        JavaScriptSerializer js = new JavaScriptSerializer();
        string did = context.Request["tid"].ToString();
        Leadin.Model.DesignTemplate model = bll.GetModel(int.Parse(did));
        
        values.Add("templatename", model.Title);
        values.Add("templatekey", model.StrKey);
        values.Add("detailcontent", model.DetailRemark);
        values.Add("hidTemId", "Design.aspx?typeid="+model.TypeId+"&tid=" + model.Id);
        values.Add("designremark", model.DesignRemark);
        values.Add("printremark", model.PrintRemark);
        values.Add("toolsremark", model.Tools);     
        
        context.Response.Write(js.Serialize(values));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
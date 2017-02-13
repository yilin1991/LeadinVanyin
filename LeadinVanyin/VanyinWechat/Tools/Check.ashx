<%@ WebHandler Language="C#" Class="Check" %>

using System;
using System.Web;
using System.Web.Security;
using System.Xml.Serialization;
using System.Xml;
using System.Configuration;
using System.IO;

public class Check : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
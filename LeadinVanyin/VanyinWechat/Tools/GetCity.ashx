<%@ WebHandler Language="C#" Class="GetCity" %>

using System;
using System.Web;
using System.Text;
using System.Data;
using System.Web.Script.Serialization;
using System.Collections.Generic;
public class GetCity : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        Vanyin.BLL.T_City bll = new Vanyin.BLL.T_City();
        Vanyin.BLL.T_District blldis = new Vanyin.BLL.T_District();
        
        JavaScriptSerializer js = new JavaScriptSerializer();

        Dictionary<string, object> values = new Dictionary<string, object>();
        
        StringBuilder strCity = new StringBuilder();
        StringBuilder strddlCity = new StringBuilder();

        StringBuilder strDistrict = new StringBuilder();
        StringBuilder strddlDistrict = new StringBuilder();
        
        string pid = context.Request["pid"].ToString();

        DataSet ds = bll.GetList("ProId=" + pid);
        strCity.Append("<div class=\"selectbox\">");
        strCity.Append("<div class=\"selectText\">");
        strCity.Append("<p>" + ds.Tables[0].Rows[0]["CityName"].ToString() + "</p>");
        strCity.Append("</div>");
        strCity.Append("<div class=\"selectico\">");
        strCity.Append("<img src=\"img/public/selectico.png\" />");
        strCity.Append("</div>");
        strCity.Append("<div class=\"selectlist\">");
        strCity.Append("<ul>");

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            strCity.Append("<li><p>" + ds.Tables[0].Rows[i]["CityName"].ToString() + "</p><input type=\"hidden\" name=\"hidvalue\"  value=\"" + ds.Tables[0].Rows[i]["CityId"].ToString() + "\" class=\"hidvalue\" /></li>");
             //<option value="<%#Eval("CityId") %>" selected="selected"><%#Eval("CityName") %></option>
            if (i == 0)
            {
                strddlCity.Append("<option value='" + ds.Tables[0].Rows[i]["CityId"].ToString() + "' selected='selected'>" + ds.Tables[0].Rows[i]["CityName"].ToString() + "</option>");
            }
            else
            {
                strddlCity.Append("<option value='" + ds.Tables[0].Rows[i]["CityId"].ToString() +"'>" + ds.Tables[0].Rows[i]["CityName"].ToString() + "</option>");
            }
        }

        strCity.Append("</ul>");
        strCity.Append("</div>");
        strCity.Append("</div>");


        values.Add("strCity", strCity.ToString());
        values.Add("strddlCity", strddlCity.ToString());

        DataSet dsDis = blldis.GetList("CityID=" + ds.Tables[0].Rows[0]["CityID"].ToString());

        strDistrict.Append("<div class=\"selectbox\">");
        strDistrict.Append("<div class=\"selectText\">");
        strDistrict.Append("<p>" + dsDis.Tables[0].Rows[0]["DisName"].ToString() + "</p>");
        
        strDistrict.Append("</div>");
        strDistrict.Append("<div class=\"selectico\">");
        strDistrict.Append("<img src=\"img/public/selectico.png\" />");
        strDistrict.Append("</div>");
        strDistrict.Append("<div class=\"selectlist\">");
        strDistrict.Append("<ul>");

        for (int j = 0; j < dsDis.Tables[0].Rows.Count; j++)
        {
            strDistrict.Append("<li><p>" + dsDis.Tables[0].Rows[j]["DisName"].ToString() + "</p><input type=\"hidden\" name=\"hidvalue\"  value=\"" + dsDis.Tables[0].Rows[j]["Id"].ToString() + "\" class=\"hidvalue\" /></li>");
            //<option value="<%#Eval("CityId") %>" selected="selected"><%#Eval("CityName") %></option>
            if (j == 0)
            {
                strddlDistrict.Append("<option value='" + dsDis.Tables[0].Rows[j]["Id"].ToString() + "' selected='selected'>" + dsDis.Tables[0].Rows[j]["DisName"].ToString() + "</option>");
            }
            else
            {
                strddlDistrict.Append("<option value='" + dsDis.Tables[0].Rows[j]["Id"].ToString() + "'>" + dsDis.Tables[0].Rows[j]["DisName"].ToString() + "</option>");
            }
        }

        strDistrict.Append("</ul>");
        strDistrict.Append("</div>");
        strDistrict.Append("</div>");


        values.Add("strDistrict", strDistrict.ToString());
        values.Add("strddlDistrict", strddlDistrict.ToString());
        
        
        
        
        context.Response.Write(js.Serialize(values));
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}
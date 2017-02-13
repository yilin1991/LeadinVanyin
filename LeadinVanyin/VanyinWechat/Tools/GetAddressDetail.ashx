<%@ WebHandler Language="C#" Class="GetAddressDetail" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;

using System.Text;
using System.Data;

public class GetAddressDetail : IHttpHandler 
{
    
    public void ProcessRequest (HttpContext context) 
    {

        JavaScriptSerializer js = new JavaScriptSerializer();

        Dictionary<string, object> values = new Dictionary<string, object>();

        StringBuilder strCity = new StringBuilder();
        StringBuilder strddlCity = new StringBuilder();

        StringBuilder strDistrict = new StringBuilder();
        StringBuilder strddlDistrict = new StringBuilder();      
        
        Vanyin.BLL.Vanyin_Harvest bll = new Vanyin.BLL.Vanyin_Harvest();
        Vanyin.BLL.T_City bllCity = new Vanyin.BLL.T_City();
        Vanyin.BLL.T_District bllDistrict = new Vanyin.BLL.T_District();
        
        
        string hidAid = context.Request["hidAid"].ToString();               
        Vanyin.Model.Vanyin_Harvest model = bll.GetModel(int.Parse(hidAid));

        values.Add("Name",model.Harvesr_Name);
        values.Add("Tel", model.Harvesr_tel);
        values.Add("Address", model.Harvesr_Address);
        values.Add("Pid", model.pid);
        
        DataSet dscity = bllCity.GetList("ProID="+model.pid);
        DataSet dsdistrict = bllDistrict.GetList("CityID="+model.cid);

        strCity.Append("<div class=\"selectbox\">");
        strCity.Append("<div class=\"selectText\">");
        strCity.Append("<p>" + dscity.Tables[0].Rows[0]["CityName"].ToString() + "</p>");
        strCity.Append("</div>");
        strCity.Append("<div class=\"selectico\">");
        strCity.Append("<img src=\"img/public/selectico.png\" />");
        strCity.Append("</div>");
        strCity.Append("<div class=\"selectlist\">");
        strCity.Append("<ul>");

        for (int i = 0; i < dscity.Tables[0].Rows.Count; i++)
        {
            strCity.Append("<li><p>" + dscity.Tables[0].Rows[i]["CityName"].ToString() + "</p><input type=\"hidden\" name=\"hidvalue\"  value=\"" + dscity.Tables[0].Rows[i]["CityId"].ToString() + "\" class=\"hidvalue\" /></li>");
            //<option value="<%#Eval("CityId") %>" selected="selected"><%#Eval("CityName") %></option>
            if (dscity.Tables[0].Rows[i]["CityId"].ToString() == model.cid.ToString())
            {
                strddlCity.Append("<option value='" + dscity.Tables[0].Rows[i]["CityId"].ToString() + "' selected='selected'>" + dscity.Tables[0].Rows[i]["CityName"].ToString() + "</option>");
            }
            else
            {
                strddlCity.Append("<option value='" + dscity.Tables[0].Rows[i]["CityId"].ToString() + "'>" + dscity.Tables[0].Rows[i]["CityName"].ToString() + "</option>");
            }
        }

        strCity.Append("</ul>");
        strCity.Append("</div>");
        strCity.Append("</div>");


        values.Add("strCity", strCity.ToString());
        values.Add("strddlCity", strddlCity.ToString());

        strDistrict.Append("<div class=\"selectbox\">");
        strDistrict.Append("<div class=\"selectText\">");
        strDistrict.Append("<p>" + dsdistrict.Tables[0].Rows[0]["DisName"].ToString() + "</p>");

        strDistrict.Append("</div>");
        strDistrict.Append("<div class=\"selectico\">");
        strDistrict.Append("<img src=\"img/public/selectico.png\" />");
        strDistrict.Append("</div>");
        strDistrict.Append("<div class=\"selectlist\">");
        strDistrict.Append("<ul>");

        for (int j = 0; j < dsdistrict.Tables[0].Rows.Count; j++)
        {
            strDistrict.Append("<li><p>" + dsdistrict.Tables[0].Rows[j]["DisName"].ToString() + "</p><input type=\"hidden\" name=\"hidvalue\"  value=\"" + dsdistrict.Tables[0].Rows[j]["Id"].ToString() + "\" class=\"hidvalue\" /></li>");
            //<option value="<%#Eval("CityId") %>" selected="selected"><%#Eval("CityName") %></option>
            if (dsdistrict.Tables[0].Rows[j]["Id"].ToString() == model.did.ToString())
            {
                strddlDistrict.Append("<option value='" + dsdistrict.Tables[0].Rows[j]["Id"].ToString() + "' selected='selected'>" + dsdistrict.Tables[0].Rows[j]["DisName"].ToString() + "</option>");
            }
            else
            {
                strddlDistrict.Append("<option value='" + dsdistrict.Tables[0].Rows[j]["Id"].ToString() + "'>" + dsdistrict.Tables[0].Rows[j]["DisName"].ToString() + "</option>");
            }
        }

        strDistrict.Append("</ul>");
        strDistrict.Append("</div>");
        strDistrict.Append("</div>");


        values.Add("strDistrict", strDistrict.ToString());
        values.Add("strddlDistrict", strddlDistrict.ToString());
        
         
        context.Response.Write(js.Serialize(values));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
<%@ WebHandler Language="C#" Class="AddAddress" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class AddAddress : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        Dictionary<string, object> values = new Dictionary<string, object>();
        JavaScriptSerializer js = new JavaScriptSerializer();

        string name = context.Request["name"].ToString();
        string pid = context.Request["pid"].ToString();
        string cid = context.Request["cid"].ToString();
        string did = context.Request["did"].ToString();
        string address = context.Request["address"].ToString();
        string tel = context.Request["tel"].ToString();
        string type = context.Request["type"].ToString();
        
        if (string.IsNullOrWhiteSpace(name))
        {
            values.Add("state", false);
            values.Add("message", "收货人姓名不能为空");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(pid) || string.IsNullOrWhiteSpace(cid) || string.IsNullOrWhiteSpace(did))
            {
                values.Add("state", false);
                values.Add("message", "请选择收获地址");
            }
            else
            {

                if (string.IsNullOrWhiteSpace(address))
                {
                    values.Add("state", false);
                    values.Add("message", "请填写您的详细地址");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(tel))
                    {
                        values.Add("state", false);
                        values.Add("message", "请填写手机号码");
                    }
                    else
                    {
                        Regex regTel = new Regex(@"^1[3|4|5|7|8][0-9]\d{8}$");

                        if (!regTel.IsMatch(tel))
                        {
                            values.Add("state", false);
                            values.Add("message", "请填写正确的手机号码");
                        }
                        else
                        {
                            Vanyin.BLL.Vanyin_Harvest bll = new Vanyin.BLL.Vanyin_Harvest();
                            Vanyin.Model.Vanyin_Harvest model = new Vanyin.Model.Vanyin_Harvest();

                            model.Harvesr_Address = address;
                            model.Harvesr_Date = DateTime.Now;
                            model.Harvesr_Member = 10117;
                            model.Harvesr_Name = name;
                            model.Harvesr_tel = tel;
                            model.cid = int.Parse(cid);
                            model.did = int.Parse(did);
                            model.pid = int.Parse(pid);
                            model.Harvesr_City = "0";
                            model.del = 0;

                            if (string.Equals(type, "add"))
                            {
                                int aid = bll.Add(model);
                                if (aid > 0)
                                {
                                    values.Add("state", true);
                                    System.Text.StringBuilder strHtml = new System.Text.StringBuilder();
                                    strHtml.Append("<div class=\"addli\">");
                                    strHtml.Append("<ul>");
                                    strHtml.Append("<li>");
                                    strHtml.Append("<p><span>" + name + "</span><span>" + tel + "</span></p>");
                                    strHtml.Append("<p>" + address + "</p>");
                                    strHtml.Append("</li>");
                                    strHtml.Append("<li class=\"editAddress\">");
                                    strHtml.Append("<a href=\"javascript:void(0)\">");
                                    strHtml.Append("<input type=\"hidden\" class=\"hidAid\" value='" + aid + "' />");
                                    strHtml.Append("<img src=\"img/public/editaddico.png\" /></a>");
                                    strHtml.Append("</li>");
                                    strHtml.Append("</ul>");
                                    strHtml.Append("</div>");
                                    values.Add("strHtml", strHtml.ToString());
                                }
                                else
                                {
                                    values.Add("state", false);
                                    values.Add("message", "收获地址添加失败，请检查您的输入");
                                }
                            }
                            else
                            {
                                string hid = context.Request["hid"].ToString();
                                model.Harvest_ID = int.Parse(hid);

                                if (bll.Update(model))
                                {
                                    values.Add("state", true);
                                    System.Text.StringBuilder strHtml = new System.Text.StringBuilder();
                                    strHtml.Append("<ul>");
                                    strHtml.Append("<li>");
                                    strHtml.Append("<p><span>"+name+"</span><span>"+tel+"</span></p>");
                                    strHtml.Append("<p>"+GetCityName(int.Parse(hid))+ address +"</p>");
                                    strHtml.Append("</li>");
                                    strHtml.Append("<li class=\"editAddress\">");
                                    strHtml.Append("<a href=\"javascript:void(0)\">");
                                    strHtml.Append("<input type=\"hidden\" class=\"hidAid\" value='"+hid+"' />");
                                    strHtml.Append("<img src=\"img/public/editaddico.png\" /></a>");
                                    strHtml.Append("</li>");
                                    strHtml.Append("</ul>");
                                    values.Add("strHtml", strHtml.ToString());
                                }
                                else
                                {
                                    values.Add("state", false);
                                    values.Add("message", "收获地址编辑失败，请检查您的输入");
                                }
                            }
                        }
                    }
                }
            }
        }


        context.Response.Write(js.Serialize(values));
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
    /// <summary>
    /// 获取收获地址城市
    /// </summary>
    /// <param name="hid"></param>
    /// <returns></returns>
    public string GetCityName(int hid)
    {
        System.Text.StringBuilder strCityName = new System.Text.StringBuilder();

        Vanyin.BLL.T_Province bllProvince = new Vanyin.BLL.T_Province();
        Vanyin.BLL.T_City bllCity = new Vanyin.BLL.T_City();
        Vanyin.BLL.Vanyin_Harvest bllHarvest = new Vanyin.BLL.Vanyin_Harvest();
        Vanyin.BLL.T_District bllDistrict = new Vanyin.BLL.T_District();
        
        Vanyin.Model.Vanyin_Harvest model = bllHarvest.GetModel(hid);

        Vanyin.Model.T_Province modelPro = bllProvince.GetModel(int.Parse(model.pid.ToString()));


        if (modelPro.ProRemark == "直辖市")
        {
            strCityName.Append(modelPro.ProName);
        }
        else
        {
            Vanyin.Model.T_City modelcity = bllCity.GetModel(int.Parse(model.cid.ToString()));
            strCityName.Append(modelcity.CityName);
        }
        Vanyin.Model.T_District modeldis = bllDistrict.GetModel(int.Parse(model.did.ToString()));
        strCityName.Append(modeldis.DisName);


        return strCityName.ToString();


    }
}
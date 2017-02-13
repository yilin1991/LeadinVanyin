<%@ WebHandler Language="C#" Class="registered" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Web.SessionState;

public class registered : IHttpHandler, IRequiresSessionState
{
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        JavaScriptSerializer js = new JavaScriptSerializer();
        Dictionary<string, object> values = new Dictionary<string, object>();
        
        
        Vanyin.BLL.Vanyin_Member bll = new Vanyin.BLL.Vanyin_Member();

        string tel = context.Request["Tel"].ToString();
        string yzm = context.Request["yzm"].ToString();
        string imgYzm = context.Request["imgYzm"].ToString();


        if (bll.CheckPhoneNum(tel))
        {
            values.Add("state", false);
            values.Add("message", "该手机号已存在");

            context.Response.Write(js.Serialize(values));
            return;
        }

        else
        {
            if (!string.Equals(yzm.ToLower(), Vanyin.Common.Utils.GetCookie("vanyinyzm").ToLower()))
            {
                values.Add("state", false);
                values.Add("message", "您输入的手机验证码不正确");

                context.Response.Write(js.Serialize(values));
                return;
            }
            else
            {

                if (!string.Equals(imgYzm.ToLower(), context.Session["DtCode"].ToString().ToLower()))
                {
                    values.Add("state", false);
                    values.Add("message", "您输入的图形验证码不正确");

                    context.Response.Write(js.Serialize(values));
                    return;
                }

                else
                {

                    Vanyin.Model.Vanyin_Member modle = new Vanyin.Model.Vanyin_Member();

                    modle.Member_Tel = tel;
                    modle.Member_Pass = Vanyin.Common.DESEncrypt.Encrypt(tel);
                    modle.Member_Wechat = Vanyin.Common.Utils.GetCookie("openid");

                    modle.Member_Name = tel;
                    modle.Member_Available = 0;
                    modle.Member_Used = 0;
                    modle.Member_Class = 10051;
                    modle.Member_State = 10053;
                    modle.Member_ActivationState = 0;
                    modle.Member_Del = 0;
                    modle.Member_Date = DateTime.Now;
                    
                    int memberID = bll.Add(modle);
                    if (memberID > 0)
                    {
                        Vanyin.Common.Utils.WriteCookie("MemberId", memberID.ToString());
                        values.Add("state", true);
                        values.Add("message", "注册成功");

                        context.Response.Write(js.Serialize(values));
                        return;
                    }
                    
                    
                    
                
                }
                       
            
            }
        
        }
        
        
        
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
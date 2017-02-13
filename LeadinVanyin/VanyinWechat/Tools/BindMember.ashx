<%@ WebHandler Language="C#" Class="BindMember" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Data;
using System.Web.SessionState;
public class BindMember : IHttpHandler, IRequiresSessionState
{

    public void ProcessRequest(HttpContext context)
    {

        Dictionary<string, object> values = new Dictionary<string, object>();
        JavaScriptSerializer js = new JavaScriptSerializer();

        Vanyin.BLL.Vanyin_Member bll = new Vanyin.BLL.Vanyin_Member();
        

        string account = context.Request["account"].ToString();
        string pwd = context.Request["pwd"].ToString();
        string imgyzm = context.Request["imgyzm"].ToString();

        if (string.Equals(imgyzm.ToLower(), context.Session["DtCode"].ToString().ToLower()))
        {
            DataSet ds = bll.GetList("(Member_Name='" + account + "' or Member_Email='" + account + "' or Member_Tel='" + account + "') and Member_Pass='"+Vanyin.Common.DESEncrypt.Encrypt(pwd)+"'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (bll.SetWeChat(int.Parse(ds.Tables[0].Rows[0]["Member_ID"].ToString()), Vanyin.Common.Utils.GetCookie("openid")))
                {
                    values.Add("state", true);
                }
                else
                {
                    values.Add("state", false);
                    values.Add("message", "绑定帐号时发生错误，请重试或者联系我们");
                }
                
            }
            else
            {
                values.Add("state", false);
                values.Add("message", "您输入的用户名或者密码不正确，请重新输入");
            }
            
                     
        }
        else
        {
            values.Add("state", false);
            values.Add("message", "您输入的图形验证码不正确");
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

}
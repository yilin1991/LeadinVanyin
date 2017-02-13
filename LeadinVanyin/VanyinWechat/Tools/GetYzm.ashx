<%@ WebHandler Language="C#" Class="GetYzm" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Text;
public class GetYzm : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        //context.Response.ContentType = "text/plain";

        JavaScriptSerializer js = new JavaScriptSerializer();

        string telNUm = context.Request["Tel"].ToString();

        Dictionary<string, object> values = new Dictionary<string, object>();

        Vanyin.BLL.Vanyin_Member bll = new Vanyin.BLL.Vanyin_Member();


        string ret = null;
        try
        {
            if (!bll.CheckPhoneNum(telNUm))
            {


                char[] intNum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                Random rd = new Random();
                StringBuilder strRdNum = new StringBuilder();
                for (int i = 0; i < 6; i++)
                {
                    strRdNum.Append(intNum[rd.Next(intNum.Length - 1)]);
                }

                CCPRestSDK.CCPRestAPI api = new CCPRestSDK.CCPRestAPI();
                api.setAppId("aaf98f8951af2ba80151c2613c074851");

                if (api.IsInit)
                {
                    Dictionary<string, object> retData = api.SendTemplateSMS(telNUm, "1", new string[] { strRdNum.ToString(), "3" });
                    ret = retData["statusCode"].ToString();
                    if (string.Equals(ret, "000000"))
                    {
                        Vanyin.Common.Utils.WriteCookie("vanyinyzm", strRdNum.ToString(), 3);
                        values.Add("state", true);
                        values.Add("message", "短信发送成功");
                    }
                    else
                    {

                        values.Add("state", false);
                        values.Add("message", "短信发送出现错误，请重试或者联系我们");
                    }
                }
                else
                {
                    values.Add("state", false);
                    values.Add("message", "短信服务初始化失败，请稍候");
                }
            }
            else
            {
                values.Add("state", false);
                values.Add("message", "该手机号码已存在，请更换手机号码");
            }

        }
        catch (Exception exc)
        {
            ret = exc.Message;
        }
        finally
        {
            context.Response.Write(js.Serialize(values));
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
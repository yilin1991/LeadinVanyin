using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeChatAPI;
using WeChatAPI.Helpers;
using WeChatAPI.Model;

public partial class Login : System.Web.UI.Page
{
    //public string openid;

    public string appid = ConfigurationManager.AppSettings["Appid"];
    public string secret = ConfigurationManager.AppSettings["AppSecret"];
    public string token = ConfigurationManager.AppSettings["ToKen"];
    public string filepath = ConfigurationManager.AppSettings["AccessTokenPath"];

    protected void Page_Load(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(Vanyin.Common.Utils.GetCookie("openid")))
        {
       
        UserInfoCode modelUserInfoCode = GetUserInfoCode(GetCode("http://yilin2015.6655.la/Login.aspx"));

        Vanyin.Common.Utils.WriteCookie("openid", modelUserInfoCode.OpenId);
        }
        if (!IsPostBack)
        {

        }

    }



    protected void btnOK_Click(object sender, EventArgs e)
    {

    }


    /// <summary>
    /// 获取Code
    /// </summary>
    /// <param name="urlEncode"></param>
    /// <param name="scode"></param>
    /// <param name="state"></param>
    /// <returns></returns>
    public string GetCode(string urlEncode, string scode = "snsapi_userinfo", string state = "vanyin")
    {
        string code = Request.QueryString["Code"];
        if (string.IsNullOrWhiteSpace(code))
        {
            string url = string.Format(WeChatAPI.Helpers.UrlHelper.GetCode, appid, HttpUtility.UrlEncode(urlEncode, Encoding.UTF8), "code", scode, state);
            Response.Redirect(url);
            return "";
        }
        else
        {
            return code;
        }

    }


    /// <summary>
    /// 获取当前用户的OpenId
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public UserInfoCode GetUserInfoCode(string code)
    {
        string url = string.Format(WeChatAPI.Helpers.UrlHelper.GetCodeAccess_token, appid, secret, code, "authorization_code");

        return JSSerializerHelper.StringToObject<UserInfoCode>(HttpHelper.Get(url));


    }

}
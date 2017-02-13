using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeChatAPI;
using WeChatAPI.Helpers;


public partial class Button : System.Web.UI.Page
{

    string appid = ConfigurationManager.AppSettings["Appid"];
    string secret = ConfigurationManager.AppSettings["AppSecret"];
    string filepath = ConfigurationManager.AppSettings["AccessTokenPath"];
    public WeChaMethod weChat;

    protected void Page_Load(object sender, EventArgs e)
    {
        weChat = new WeChaMethod(appid, secret);
        weChat.Access_Token = weChat.AccessToken(Server.MapPath(filepath));
    }



    protected void btnAddMenu_Click(object sender, EventArgs e)
    {

        string text = readfile(ConfigurationManager.AppSettings["MenuListPath"]);

        //string urlDel = string.Format(UrlHelper.DeleteMenu, weChat.Access_Token);

        //Response.Write(HttpHelper.Get(urlDel));


        string url = string.Format(UrlHelper.CreateMenu, weChat.Access_Token);

        Response.Write(HttpHelper.Post(text.ToString(), url));

    }


    public string readfile(string paths)
    {
        StreamReader sr = new StreamReader(Server.MapPath(paths), System.Text.Encoding.Default);
        string input = sr.ReadToEnd();
        return input;
    }


}
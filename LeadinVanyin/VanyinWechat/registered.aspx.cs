using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeChatAPI.Helpers;
using WeChatAPI.Model;

public partial class registered : System.Web.UI.Page
{

    //public string appid = ConfigurationManager.AppSettings["Appid"];
    //public string secret = ConfigurationManager.AppSettings["AppSecret"];
    //public string token = ConfigurationManager.AppSettings["ToKen"];
    //public string filepath = ConfigurationManager.AppSettings["AccessTokenPath"];

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
        
        }

    }

}
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
using System.Data;


public partial class Print : System.Web.UI.Page
//public partial class Print : Vanyin.Web.UI.WeChatPage
{

    Vanyin.BLL.ClassInfo bllClass = new Vanyin.BLL.ClassInfo();
    Vanyin.BLL.Vanyin_Harvest bllHarvest = new Vanyin.BLL.Vanyin_Harvest();
    Vanyin.BLL.T_Province bllProvince = new Vanyin.BLL.T_Province();
    Vanyin.BLL.T_City bllCity = new Vanyin.BLL.T_City();
    Vanyin.BLL.T_District bllDistrict = new Vanyin.BLL.T_District();
    

    protected void Page_Load(object sender, EventArgs e)
     {

         if (!IsPostBack)
         {
             BindClass();
             BindAddress();
             BindProvince();
             BindCity();
             BindArea();
         }
    }


    /// <summary>
    /// 绑定印刷类别
    /// </summary>
    void BindClass()
    {
        DataSet ds = bllClass.GetList("ClassInfo_ParentID=10107 and ClassInfo_ID != 10150","ClassInfo_Id asc");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataSet ds1 = bllClass.GetList("ClassInfo_ParentID=" + ds.Tables[0].Rows[i]["ClassInfo_ID"].ToString(), "ClassInfo_Id asc");
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
            {
                ListItem li = new ListItem();
                li.Text = ds1.Tables[0].Rows[j]["ClassInfo_Name"].ToString();
                li.Value = ds1.Tables[0].Rows[j]["ClassInfo_ID"].ToString();
                ddlClass.Items.Add(li);
            }
        }
    }


    /// <summary>
    /// 绑定收获地址
    /// </summary>
    void BindAddress()
    {
        DataSet ds = bllHarvest.GetList("Harvesr_Member=10117", "Harvest_ID desc");
        repAddress.DataSource = ds;
        repAddress.DataBind();
    }


    //默认加载省份
    void BindProvince()
    {
        repProvince.DataSource = bllProvince.GetList("");
        repProvince.DataBind();
    }

    //默认加载城市
    void BindCity()
    {
        repCity.DataSource = bllCity.GetList("ProId=1");
        repCity.DataBind();
    }

    //默认加载区县
    void BindArea()
    {
        repDistrict.DataSource = bllDistrict.GetList("CityId=1");
        repDistrict.DataBind();
    }


    /// <summary>
    /// 获取收获地址城市
    /// </summary>
    /// <param name="hid"></param>
    /// <returns></returns>
    public string GetCityName(int hid)
    {
        System.Text.StringBuilder strCityName = new StringBuilder();

        Vanyin.Model.Vanyin_Harvest model = bllHarvest.GetModel(hid);

        Vanyin.Model.T_Province modelPro = bllProvince.GetModel(int.Parse( model.pid.ToString()));


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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
} 
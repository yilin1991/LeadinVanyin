using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace LeadinWeb
{
    public partial class index1 : Leadin.Web.UI.BasePage
    {

        Leadin.BLL.Filetable bllfile = new Leadin.BLL.Filetable();
        Leadin.BLL.DesignTemplateType bllTemplateType = new Leadin.BLL.DesignTemplateType();
        Leadin.BLL.DesignTemplate bllTemplate = new Leadin.BLL.DesignTemplate();
        Leadin.BLL.view_IndexTemplate bllViewTemplate = new Leadin.BLL.view_IndexTemplate();
        Leadin.BLL.Store bllStore = new Leadin.BLL.Store();
        Leadin.BLL.StoreCity bllStoreCity = new Leadin.BLL.StoreCity();
        Leadin.BLL.Article bllArticle = new Leadin.BLL.Article();


        public string defaultTemplateTypeId = "";
        public string defaultTemplateTypeName = "";
        public string defaultTemplateTypeRemark = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindBanner();//绑定网站Banner
                BindTemplateType();//绑定热门模版类别
                BindTemplate();
                BindStoreCity();
                BindArticle();
            }
        }


        /// <summary>
        /// 绑定网站大图
        /// </summary>
        void BindBanner()
        {
            repBanner.DataSource = bllfile.GetList(0, "TypeId=10000 and StateInfo=1", "SortNum desc");
            repBanner.DataBind();
        }

        

        /// <summary>
        /// 绑定首页模版展示类别
        /// </summary>
        void BindTemplateType()
        {
            DataSet ds = bllTemplateType.GetList(0, "StateInfo=1 and convert(nvarchar(255),DetailRemark)='1'", "SortNum desc");
            repTemplateType.DataSource = ds;
            repTemplateType.DataBind();
        }

        /// <summary>
        /// 绑定首页设计模版
        /// </summary>
        void BindTemplate()
        {
            DataSet ds = bllTemplateType.GetList(0, "StateInfo=1 and convert(nvarchar(255),DetailRemark)='1'", "SortNum desc");
            defaultTemplateTypeId = ds.Tables[0].Rows[0]["Id"].ToString();
            defaultTemplateTypeName = ds.Tables[0].Rows[0]["Title"].ToString();
            defaultTemplateTypeRemark = ds.Tables[0].Rows[0]["SubTitle"].ToString();
            GetIndexTemplate(1, int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), 10000, repBigTemplate);
            GetIndexTemplate(3, int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), 10001, repSwiperTemplate);
            GetIndexTemplate(3, int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), 10002, repSmallTemplate);
        }

        /// <summary>
        /// 获取首页模版列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        void GetIndexTemplate(int topNum, int Classid, int TypeId, Repeater rep)
        {
            DataSet ds = new Leadin.BLL.view_IndexTemplate().GetList(topNum, "ClassId=" + Classid + " and TypeId=" + TypeId + " and StateInfo=1", "SortNum desc");

            rep.DataSource = ds;
            rep.DataBind();
        }

        /// <summary>
        /// 选择模版类别时加载对应模版
        /// </summary>
        /// <param name="cid">模版类别编号</param>
        /// <returns></returns>
        [System.Web.Services.WebMethod]
        public static string SetTemplateTypeChange(string cid)
        {
            Leadin.Model.DesignTemplateType model = new Leadin.BLL.DesignTemplateType().GetModel(int.Parse(cid));
            StringBuilder strHtml = new StringBuilder();
            strHtml.Append("<li class=\"template220 temli1\">");
            strHtml.Append("<p class=\"name\">" + model.Title + "</p>");
            strHtml.Append("<p class=\"remark\">" + model.SubTitle + "</p>");
            strHtml.Append("<a class=\"more\" href=\"design.aspx?type=" + cid + "\">更多模版&nbsp;&nbsp;>></a> </li>");
            DataSet ds = new Leadin.BLL.view_IndexTemplate().GetList(0, "ClassId=" + cid + " and StateInfo=1", "SortNum desc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow[] dsBigTemplate = ds.Tables[0].Select("TypeId=10000");
                if (dsBigTemplate.Length > 0)
                {
                    strHtml.Append("<li class=\"template440 temli2\">");
                    strHtml.Append("<a class=\"temabox\" href=\"javascript:void(0)\" onclick=\"ShowDetail('" + dsBigTemplate[0]["TemplateId"].ToString() + "')\">");
                    strHtml.Append("<img src='" + dsBigTemplate[0]["ImgUrl"].ToString() + "' />");
                    strHtml.Append("<div class=\"nameprice\">");
                    strHtml.Append("<p>" + dsBigTemplate[0]["TemplateTitle"].ToString() + "</p>");
                    strHtml.Append("<p><span>" + dsBigTemplate[0]["Price"].ToString() + "</span></p>");
                    strHtml.Append("</div>");
                    strHtml.Append("</a>");
                    strHtml.Append("</li>");
                }
                DataRow[] dsSwiperTemplate = ds.Tables[0].Select("TypeId=10001");
                if (dsSwiperTemplate.Length > 0)
                {
                    strHtml.Append("<li class=\"template4402\">");
                    strHtml.Append("<div class=\"swiper-container swiperdesign\">");
                    strHtml.Append("<div class=\"swiper-wrapper\">");
                    for (int i = 0; i < dsSwiperTemplate.Length; i++)
                    {
                        strHtml.Append("<div class=\"swiper-slide\">");
                        strHtml.Append("<a  href=\"javascript:void(0)\" onclick=\"ShowDetail('" + dsSwiperTemplate[i]["TemplateId"].ToString() + "')\">");
                        strHtml.Append("<img src='" + dsSwiperTemplate[i]["ImgUrl"].ToString() + "' />");
                        strHtml.Append("<div class=\"nameprice\">");
                        strHtml.Append("<p>" + dsSwiperTemplate[i]["TemplateTitle"].ToString() + "</p>");
                        strHtml.Append("<p><span>" + dsSwiperTemplate[i]["Price"].ToString() + "</span></p>");
                        strHtml.Append("</div>");
                        strHtml.Append("</a>");
                        strHtml.Append("</div>");
                    }
                    strHtml.Append("</div>");
                    strHtml.Append("<div class=\"paginationdesign\"></div>");
                    strHtml.Append("</div>");
                    strHtml.Append("</li>");
                }
                DataRow[] dsSmallTemplate = ds.Tables[0].Select("TypeId=10002");

                if (dsSmallTemplate.Length > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        strHtml.Append("<li class=\"template220\">");
                        strHtml.Append("<a class=\"temabox\" href=\"javascript:void(0)\" onclick=\"ShowDetail('" + dsSmallTemplate[i]["TemplateId"].ToString() + "')\">");
                        strHtml.Append("<img src=\"" + dsSmallTemplate[i]["ImgUrl"].ToString() + "\" />");
                        strHtml.Append("<div class=\"nameprice\">");
                        strHtml.Append("<p>" + dsSmallTemplate[i]["TemplateTitle"].ToString() + "</p>");
                        strHtml.Append("<p><span>" + dsSmallTemplate[i]["Price"].ToString() + "</p>");
                        strHtml.Append("</div>");
                        strHtml.Append("</a>");
                        strHtml.Append("</li>");
                    }
                }
            }
            return strHtml.ToString();
        }


        /// <summary>
        /// 绑定门店城市以及默认默认门店
        /// </summary>
        void BindStoreCity()
        {
            DataSet ds = bllStoreCity.GetList(0,"StateInfo=1 and ParentId!=0","SortNum desc");

            repStoreCity.DataSource = ds;
            repStoreCity.DataBind();

            DataSet dsStore = bllStore.GetList(0, "StateInfo=1 and IsIndex=1 and City="+ds.Tables[0].Rows[0]["Id"].ToString(), "SortNum desc,AddTime desc");

            repStore.DataSource = dsStore;
            repStore.DataBind();

        }


        /// <summary>
        /// 获取城市名称
        /// </summary>
        /// <returns></returns>
        public string GetCityName(string id)
        {
            Leadin.Model.StoreCity model = bllStoreCity.GetModel(int.Parse(id));
            return bllStoreCity.GetModel(model.ParentId).Title + model.Title;
        }

        /// <summary>
        /// 选择门店城市时加载对应门店
        /// </summary>
        /// <param name="cid">模版类别编号</param>
        /// <returns></returns>
        [System.Web.Services.WebMethod]
        public static string SetStoreCityChange(string cid)
        {

            StringBuilder strHtml = new StringBuilder();

            DataSet ds = new Leadin.BLL.Store().GetList(0, "StateInfo=1 and IsIndex=1 and City=" + cid, "SortNum desc,AddTime desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                strHtml.Append("<ul>");
                strHtml.Append("<li class=\"img\">");
                strHtml.Append("<a href=\"#\"><img src=\"" + item["ImgUrl"].ToString() + "\" /></a>");
                strHtml.Append("</li>");
                strHtml.Append("<li class=\"detail\">");
                strHtml.Append("<a class=\"title\" href=\"#\">" + item["Title"].ToString() + "</a>");
                strHtml.Append("<p>地址：" + item["AddressInfo"].ToString() + "</p>");
                strHtml.Append("<p>营业时间：" + item["BusinessTime"].ToString() + " </p>");
                strHtml.Append("<p>支付方式：" + item["PayType"].ToString() + " </p>");
                strHtml.Append("</li>");
                strHtml.Append("</ul>");
            }
            

            return strHtml.ToString();

        }

        /// <summary>
        /// 绑定首页资讯
        /// </summary>
        void BindArticle()
        {
            DataSet ds = bllArticle.GetList(4, "StateInfo=1 and IsIndex=1 and TypeId=10002", "AddTime desc,Id desc");
            repNews.DataSource = ds;
            repNews.DataBind();

            DataSet dsDesign = bllArticle.GetList(1, "StateInfo=1 and IsIndex=1 and TypeId=10001", "AddTime desc,Id desc");
            repNewDesign.DataSource = dsDesign;
            repNewDesign.DataBind();

            DataSet dsPrint = bllArticle.GetList(1, "StateInfo=1 and IsIndex=1 and TypeId=10000", "AddTime desc,Id desc");
            repNewPrint.DataSource = dsPrint;
            repNewPrint.DataBind();

        }


    }
}
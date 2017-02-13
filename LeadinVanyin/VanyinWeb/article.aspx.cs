using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
namespace LeadinWeb
{
    public partial class article : System.Web.UI.Page
    {

        public int pagesize = 8;
        public int page;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();


        Leadin.BLL.Article bll = new Leadin.BLL.Article();

        public string typeid;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindArticleList();
            }
        }



        /// <summary>
        /// 绑定资讯列表
        /// </summary>
        void BindArticleList()
        {
            string strWhere = "";
            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }
            if (string.IsNullOrEmpty(Request.Params["type"]))
            {
                strWhere = "StateInfo=1 and TypeId=" + 10001;
                strUrl.Append("&type=10001");
                typeid = "10001";
            }
            else
            {
                strWhere = "StateInfo=1 and TypeId=" + Request.Params["type"];
                strUrl.Append("&type=" + Request.Params["type"]);
                typeid = Request.Params["type"];
            }
            pcount = bll.GetRecordCount(strWhere);
            repArticle.DataSource = bll.GetPageList(pagesize, page, strWhere, "AddTime desc,Id desc");
            repArticle.DataBind();

        }



    }
}
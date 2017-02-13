using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace LeadinWeb.Vanyin.Mall.Order
{
    public partial class List : System.Web.UI.Page
    {

        public int pagesize = 10;
        public int page;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();


        Leadin.BLL.ExchangeOrder bll = new Leadin.BLL.ExchangeOrder();
        Leadin.BLL.ExOrderRecord bllRecord = new Leadin.BLL.ExOrderRecord();
        Leadin.BLL.view_MallOrder bllMallOrder = new Leadin.BLL.view_MallOrder();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }


        /// <summary>
        /// 绑定兑换订单列表
        /// </summary>
        void BindRepList()
        {
            StringBuilder strWhere=new StringBuilder();

            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }

            pcount = bllMallOrder.GetRecordCount(strWhere.ToString());

            repList.DataSource = bllMallOrder.GetListByPage(strWhere.ToString(), "AddTime desc", pagesize * page, pagesize * page + pagesize);
            repList.DataBind();

        }

        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnAllList_Click(object sender, EventArgs e)
        {

        }

      

    }
}
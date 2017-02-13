using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace LeadinWeb.Vanyin.Index.Template
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        public int pagesize = 10;
        public int page;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.view_IndexTemplate bll = new Leadin.BLL.view_IndexTemplate();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }


        /// <summary>
        /// 绑定列表
        /// </summary>
        void BindRepList()
        {
            StringBuilder strWhere = new StringBuilder();

            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }
            pcount = bll.GetRecordCount(strWhere.ToString());

            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "TypeId desc,SortNum desc,AddTime desc", pagesize * page, pagesize * page + pagesize);
            repList.DataBind();


        }


        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }





    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Designer
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        public int page;
        public int pagesize = 10;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.Designer bll = new Leadin.BLL.Designer();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
                BindRepList();
            }
        }




        /// <summary>
        /// 绑定会员列表
        /// </summary>
        void BindRepList()
        {

            StringBuilder strWhere = new StringBuilder();



            strWhere.Append("1=1 ");


            if (!string.IsNullOrEmpty(Request.Params["key"]))
            {
                strWhere.Append(" and NameInfo like '%" + Request.Params["key"] + "%'");
                strUrl.Append("&key=" + Request.Params["key"]);
                txtKey.Text = Request.Params["key"];
            }



            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }

            pcount = bll.GetRecordCount(strWhere.ToString());
            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "Num desc", page * pagesize, page * pagesize + pagesize);
            repList.DataBind();

        }



        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?key=" + txtKey.Text);
        }


        /// <summary>
        /// 显示全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }


        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "lbtnState")
            {
                HiddenField hidId = e.Item.FindControl("hidId") as HiddenField;
                Leadin.Model.Designer model = bll.GetModel(int.Parse(hidId.Value));
                if (model.StateInfo == 1)
                {
                    model.StateInfo = 0;
                }
                else
                {
                    model.StateInfo = 1;
                }
                bll.Update(model);
            }

            BindRepList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace LeadinWeb.Vanyin.DesignTemplate.Type
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        public int page;
        public int pagesize = 10;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();


        Leadin.BLL.DesignTemplateType bll = new Leadin.BLL.DesignTemplateType();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }



        /// <summary>
        /// 绑定类别状态列表
        /// </summary>
        void BindRepList()
        {


            StringBuilder strWhere = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(Request.Params["key"]))
            {
                strWhere.Append("Title like '%" + Request.Params["key"] + "%'");
                txtKey.Text = Request.Params["key"];
                strUrl.Append("&key=" + Request.Params["key"]);
            }


            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }


            pcount = bll.GetList(strWhere.ToString()).Tables[0].Rows.Count;

            repList.DataSource = bll.GetPageList(pagesize,page,strWhere.ToString(),"SortNum desc,Id desc");
            repList.DataBind();
        }



        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //修改状态
            if (e.CommandName == "lbtnState")
            {
                Label lbid = e.Item.FindControl("lbid") as Label;

                Leadin.Model.DesignTemplateType model = bll.GetModel(int.Parse(lbid.Text));

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
            //修改热门
            if (e.CommandName == "lbtnHot")
            {
                Label lbid = e.Item.FindControl("lbid") as Label;

                Leadin.Model.DesignTemplateType model = bll.GetModel(int.Parse(lbid.Text));

                if (model.DetailRemark == "1")
                {
                    model.DetailRemark = "0";
                }
                else
                {
                    model.DetailRemark = "1";
                }

                bll.Update(model);

            }

            BindRepList();

        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                JsMessage("error", "请输入搜索的关键字", 1000, "back");
            }
            else
            {
                Response.Redirect("List.aspx?key=" + txtKey.Text);
            }
        }

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }
    }
}
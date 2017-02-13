using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace LeadinWeb.Vanyin.Article.Article
{
    public partial class List : System.Web.UI.Page
    {

        public int pagesize = 10;
        public int page;
        public int pcount;

        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.Article bll = new Leadin.BLL.Article();
        Leadin.BLL.ArticleType bllType = new Leadin.BLL.ArticleType();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindType();
                BindList();
            }
        }

        /// <summary>
        /// 绑定资讯类别
        /// </summary>
        void BindType()
        {
            DataSet ds = bllType.GetList("ParentId=0 and StateInfo=1");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddltype.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }
        }


        /// <summary>
        /// 绑定资讯列表
        /// </summary>
        void BindList()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("1=1");

            int typeid;
            int keytypeid;

            if (int.TryParse(Request.Params["type"], out typeid))
            {
                if (!string.Equals(Request.Params["type"], "0"))
                {
                    strWhere.Append(" and TypeId=" + typeid);
                }
                ddltype.SelectedValue = typeid.ToString();
                strUrl.Append("&type=" + typeid);

            }

            if (int.TryParse(Request.Params["keytype"], out keytypeid))
            {
                if (string.IsNullOrEmpty(Request.Params["key"]))
                {
                    switch (Request.Params["keytype"])
                    {
                        case "1":
                            strWhere.Append(" and Num='" + Request.Params["key"] + "'");
                            break;
                        case "2":
                            strWhere.Append(" and (Title like '%" + Request.Params["key"] + "%' or SubTitle like '%" + Request.Params["key"] + "%' or StrKey like '%" + Request.Params["key"] + "%')");
                            break;
                    }
                }

                strUrl.Append("&keytype=" + keytypeid + "&key=" + txtKey.Text);
                txtKey.Text = Request.Params["key"];
                ddlKey.SelectedValue = keytypeid.ToString();
            }


            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }

            pcount = bll.GetRecordCount(strWhere.ToString());
            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "Id desc", pagesize * page, pagesize * page + pagesize);
            repList.DataBind();
        }



        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?type=" + ddltype.SelectedValue + "&keytype=" + ddlKey.SelectedValue + "&key=" + txtKey.Text);
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
        /// 属性改变
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "lbtnState")//修改状态
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.Article model = bll.GetModel(int.Parse(hidid.Value));

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
            if (e.CommandName == "lbtnIndex")//修改是否首页显示
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.Article model = bll.GetModel(int.Parse(hidid.Value));

                if (model.IsIndex == 1)
                {
                    model.IsIndex = 0;
                }
                else
                {
                    model.IsIndex = 1;
                }

                bll.Update(model);
            }
            if (e.CommandName == "lbtnhot")//修改是否热门显示
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.Article model = bll.GetModel(int.Parse(hidid.Value));

                if (model.IsHot == 1)
                {
                    model.IsHot = 0;
                }
                else
                {
                    model.IsHot = 1;
                }

                bll.Update(model);
            }
            if (e.CommandName == "lbtnRec")//修改是否推荐显示
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.Article model = bll.GetModel(int.Parse(hidid.Value));

                if (model.IsRec == 1)
                {
                    model.IsRec = 0;
                }
                else
                {
                    model.IsRec = 1;
                }

                bll.Update(model);
            }

            BindList();
        }


        /// <summary>
        /// 获取资讯类别名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetTypeName(string id)
        {
            return bllType.GetModel(int.Parse(id)).Title;
        }

    }
}
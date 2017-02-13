using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Web.Services;

namespace LeadinWeb.Vanyin.Store.Store
{
    public partial class List : System.Web.UI.Page
    {

        public int pagesize = 10;
        public int page;
        public int pcount;

        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.Store bll = new Leadin.BLL.Store();
        Leadin.BLL.StoreCity bllcity = new Leadin.BLL.StoreCity();
        Leadin.BLL.StoreType blltype = new Leadin.BLL.StoreType();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindType();
                if (string.IsNullOrEmpty(Request.Params["city"]))
                {
                    BindCity();
                }
                else
                {
                    BindCity(int.Parse(Request.Params["city"]));
                }
                BindList();

            }
        }


        /// <summary>
        /// 一级城市改变获取二级城市方法
        /// </summary>
        /// <param name="cid">一级城市编号</param>
        /// <returns></returns>
        [WebMethod]
        public static string SetChange(string cid)
        {
            StringBuilder strHtml = new StringBuilder();

            if (string.Equals(cid, "0"))
            {
                strHtml.Append("<option value=\"0\">请选择二级城市</option>");
            }
            else
            {
                Leadin.BLL.StoreCity bllcity1 = new Leadin.BLL.StoreCity();
                DataSet ds = bllcity1.GetList(0, "StateInfo=1 and ParentId=" + cid, "SortNum desc,Id desc");


                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    strHtml.Append("<option value=\"" + item["Id"].ToString() + "\">" + item["Title"].ToString() + "</option>");
                }
            }
            return strHtml.ToString();
        }

        /// <summary>
        /// 绑定门店列表
        /// </summary>
        void BindList()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("1=1");

            int typeid;
            int cityid;
            int keytypeid;

            if (int.TryParse(Request.Params["type"], out typeid))
            {
                if (!string.Equals(Request.Params["type"], "0"))
                {
                    strWhere.Append(" and StoreType=" + typeid);
                }
                ddltype.SelectedValue = typeid.ToString();
                strUrl.Append("&type=" + typeid);

            }
            if (int.TryParse(Request.Params["city"], out cityid))
            {
                if (cityid!=0)
                {
                    strWhere.Append(" and City=" + cityid);
                }
                strUrl.Append("&city=" + cityid);

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
                            strWhere.Append(" and (Title like '%" + Request.Params["key"] + "%' or PayType like '%" + Request.Params["key"] + "%' or Scope like '%" + Request.Params["key"] + "%')");
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
            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "SortNum desc,Id desc", pagesize * page, pagesize * page + pagesize);
            repList.DataBind();
        }


        /// <summary>
        /// 获取类别名称
        /// </summary>
        /// <param name="id">类别编号</param>
        /// <returns></returns>
        public string GetTypeName(string id)
        {
            return blltype.GetModel(int.Parse(id)).Title;
        }


        /// <summary>
        /// 绑定门店类别
        /// </summary>
        void BindType()
        {
            DataSet ds = blltype.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddltype.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }

        /// <summary>
        /// 绑定门店城市
        /// </summary>
        void BindCity()
        {
            DataSet ds = bllcity.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

            DataSet dsSub = bllcity.GetList(0, "StateInfo=1 and ParentId=" + ds.Tables[0].Rows[0]["Id"].ToString(), "SortNum desc,Id desc");

            foreach (DataRow item in dsSub.Tables[0].Rows)
            {
                ddlSubCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }

        /// <summary>
        /// 绑定门店城市
        /// </summary>
        void BindCity(int cid)
        {
            if (cid == 0)
            {
                ddlCity.Items.Add(new ListItem("请选择一级城市", "0"));
                ddlSubCity.Items.Add(new ListItem("请选择二级城市", "0"));
            }
            else
            {
                int parentId = bllcity.GetModel(cid).ParentId;

                DataSet ds = bllcity.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    ddlCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
                }

                DataSet dssub = bllcity.GetList("StateInfo=1 and ParentId=" + parentId);
                ddlSubCity.Items.Clear();
                foreach (DataRow item in dssub.Tables[0].Rows)
                {
                    ddlSubCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
                }

                ddlSubCity.SelectedValue = cid.ToString();
                ddlCity.SelectedValue = parentId.ToString();
            }
        }

        /// <summary>
        /// 获取城市名称
        /// </summary>
        /// <returns></returns>
        public string GetCityName(string id)
        {
            Leadin.Model.StoreCity model = bllcity.GetModel(int.Parse(id));
            return bllcity.GetModel(model.ParentId).Title + model.Title;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?type=" + ddltype.SelectedValue + "&city=" + Request.Form[ddlSubCity.UniqueID] + "&keytype=" + ddlKey.SelectedValue + "&key=" + txtKey.Text);
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

                Leadin.Model.Store model = bll.GetModel(int.Parse(hidid.Value));

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

                Leadin.Model.Store model = bll.GetModel(int.Parse(hidid.Value));

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

                Leadin.Model.Store model = bll.GetModel(int.Parse(hidid.Value));

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

                Leadin.Model.Store model = bll.GetModel(int.Parse(hidid.Value));

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


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;



namespace LeadinWeb.Vanyin.FileInfo.FileInfo
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        public int pagesize = 10;
        public int page;
        public int pcount;

        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.Filetable bll = new Leadin.BLL.Filetable();
        Leadin.BLL.FileType blltype = new Leadin.BLL.FileType();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                BindType();
                BindList();
            }
        }


        /// <summary>
        /// 绑定文件类别
        /// </summary>
        void BindType()
        {
            DataSet ds = blltype.GetList("ParentId=0 and StateInfo=1");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddltype.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }


        /// <summary>
        /// 绑定文件列表
        /// </summary>
        void BindList() 
        {
            StringBuilder strWhere=new StringBuilder();

            strWhere.Append("1=1");

            if (!string.IsNullOrEmpty(Request.Params["type"]))
            {
                if (!string.Equals(Request.Params["type"], "0"))
                {
                    strWhere.Append(" and TypeId=" + Request.Params["type"]);
                }
                strUrl.Append("&type=" + Request.Params["type"]);
                ddltype.SelectedValue = Request.Params["type"];

            }


            if (!string.IsNullOrEmpty(Request.Params["keytype"]))
            {
                if (!string.Equals(Request.Params["keytype"], "0"))
                {

                    if (!string.IsNullOrEmpty(Request.Params["key"]))
                    {
                        switch (Request.Params["keytype"])
                        {

                            case "1":
                                strWhere.Append(" and Num='" + Request.Params["key"] + "'");
                                break;

                            case "2":
                                strWhere.Append(" and Title like '%" + Request.Params["key"] + "%'");
                                break;
                        }
                    }

                }

                ddlKey.SelectedValue = Request.Params["keytype"];
                txtKey.Text = Request.Params["key"];
                strUrl.Append("&keytype=" + Request.Params["keytype"] + "&key=" + Request.Params["key"]);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetTypeName(int id)
        {
            return blltype.GetModel(id).Title;
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

                Leadin.Model.Filetable model = bll.GetModel(int.Parse(hidid.Value));

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

            if (e.CommandName == "lbtnhot")//修改是否热门显示
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.Filetable model = bll.GetModel(int.Parse(hidid.Value));

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

                Leadin.Model.Filetable model = bll.GetModel(int.Parse(hidid.Value));

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
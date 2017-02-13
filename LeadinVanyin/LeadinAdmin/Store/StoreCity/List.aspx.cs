using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Store.StoreCity
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.StoreCity bll = new Leadin.BLL.StoreCity();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }


        /// <summary>
        /// 绑定类别列表
        /// </summary>
        void BindRepList()
        {

            
            
            System.Text.StringBuilder strWhere = new System.Text.StringBuilder();

            strWhere.Append("ParentId=0");

            if (!string.IsNullOrEmpty(Request.Params["key"]))
            {
                strWhere.Append(" and Title like '%"+Request.Params["key"]+"%'");
                txtKey.Text = Request.Params["key"];
            }

            

            repList.DataSource = bll.GetList(strWhere.ToString());
            repList.DataBind();
        }



        /// <summary>
        /// 改变状态
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //修改状态
            if (e.CommandName == "lbtnState")
            {
                Label lbid = e.Item.FindControl("lbid") as Label;

                Leadin.Model.StoreCity model = bll.GetModel(int.Parse(lbid.Text));

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


       /// <summary>
       /// 获取上级城市名称
       /// </summary>
       /// <returns></returns>
        public string GetCityName(string id)
        {
            if (string.Equals(id, "0"))
            {
                return "一级城市";
            }
            else
            {
                return bll.GetModel(int.Parse(id)).Title;
            }
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
        /// 查看全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }

    }
}
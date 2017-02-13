using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Index.Type
{
    public partial class List : System.Web.UI.Page
    {
        Leadin.BLL.IndexType bll = new Leadin.BLL.IndexType();

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
            repList.DataSource = bll.GetList("ParentId=1");
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

                Leadin.Model.IndexType model = bll.GetModel(int.Parse(lbid.Text));

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
        /// 获取父类别名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetParentName(string id)
        {
            string parentName = "";
            switch (id)
            { 
                case "1":
                    parentName = "模版类别";
                    break;
                case "2":
                    parentName = "案例类别";
                    break;
            }
            return parentName;
        }


    }
}
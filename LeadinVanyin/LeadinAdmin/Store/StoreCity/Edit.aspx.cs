using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Store.StoreCity
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.StoreCity blltype = new Leadin.BLL.StoreCity();

        public int typeid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindType();
                if (int.TryParse(Request.Params["id"], out typeid))
                {
                  
                    BindDetail(typeid);
                }
            }
        }


        /// <summary>
        /// 绑定顶级城市
        /// </summary>
        void BindType()
        {
            System.Data.DataSet ds = blltype.GetList(0,"ParentId=0","SortNum desc");


            foreach (System.Data.DataRow item in ds.Tables[0].Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }


            if (!string.IsNullOrEmpty(Request.Params["typeid"]))
            {
                ddlType.SelectedValue = Request.Params["typeid"];
            }

        }


        /// <summary>
        /// 绑定会员类别详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.StoreCity model = blltype.GetModel(typeid);

            ddlType.SelectedValue = model.ParentId.ToString();
            txtRemark.Text = model.Remark;
            txtSortNum.Text = model.SortNum.ToString();
            txtTypeName.Text = model.Title;
            ckState.Checked = model.StateInfo == 1 ? true : false;


        }


        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.StoreCity model = new Leadin.Model.StoreCity();


            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = blltype.GetModel(int.Parse(Request.Params["id"]));
            }



            model.ParentId = int.Parse(ddlType.SelectedValue);
            model.Remark = txtRemark.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;

            model.Title = txtTypeName.Text;
             


            if (IsEdit)
            {
                if (blltype.Add(model) > 0)
                {

                    if (!string.IsNullOrEmpty(Request.Params["typeid"]))
                    {
                        JsMessage("success", "门店城市添加成功！", 1000, "SubList.aspx");
                    }
                    else
                    {
                        JsMessage("success", "门店城市添加成功！", 1000, "List.aspx");
                    }
                }
                else
                {
                    JsMessage("error", "门店城市添加失败，请检查您的输入！", 1000, "back");
                }

            }
            else
            {
                if (blltype.Update(model))
                {

                    if (string.IsNullOrEmpty(Request.Params["typeid"]))
                    {
                        JsMessage("success", "门店城市编辑成功！", 1000, "List.aspx?page=" + Request.Params["page"]);
                    }
                    else
                    {
                        JsMessage("success", "门店城市编辑成功！", 1000, "SubList.aspx?typeid="+Request.Params["typeid"]);
                    }
                }
                else
                {
                    JsMessage("error", "门店城市编辑失败，请检查您的输入！", 1000, "back");
                }

            }

        }
    }
}
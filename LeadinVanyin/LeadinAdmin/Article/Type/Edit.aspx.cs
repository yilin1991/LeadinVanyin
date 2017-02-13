using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Article.Type
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {

        Leadin.BLL.ArticleType blltype = new Leadin.BLL.ArticleType();

        public int typeid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.Params["id"], out typeid))
                {
                    BindDetail(typeid);
                }
            }
        }


        /// <summary>
        /// 绑定会员类别详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.ArticleType model = blltype.GetModel(typeid);

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
            Leadin.Model.ArticleType model = new Leadin.Model.ArticleType();


            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = blltype.GetModel(int.Parse(Request.Params["id"]));
            }



            model.ParentId = 0;
            model.Remark = txtRemark.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;

            model.Title = txtTypeName.Text;



            if (IsEdit)
            {


                if (blltype.Add(model) > 0)
                {
                    JsMessage("success", "资讯类别添加成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "资讯类别添加失败，请检查您的输入！", 1000, "back");
                }

            }
            else
            {
                if (blltype.Update(model))
                {
                    JsMessage("success", "资讯类别编辑成功！", 1000, "List.aspx?page=" + Request.Params["page"]);
                }
                else
                {
                    JsMessage("error", "资讯类别编辑失败，请检查您的输入！", 1000, "back");
                }

            }

        }
    }
}
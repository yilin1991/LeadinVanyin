using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LeadinWeb.Vanyin.Article.Article
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.Article bll = new Leadin.BLL.Article();
        Leadin.BLL.ArticleType blltype = new Leadin.BLL.ArticleType();

        int aid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindType();
                if (int.TryParse(Request.Params["id"], out aid))
                {
                    BindDetail(aid);
                }
            }
        }

        /// <summary>
        /// 绑定文章类别
        /// </summary>
        void BindType()
        {
            DataSet ds = blltype.GetList("ParentId=0 and StateInfo=1");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(),item["Id"].ToString()));
            }

        }


        /// <summary>
        /// 绑定文章详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.Article model = bll.GetModel(id);
            txtAuthor.Text = model.Author;
            txtContent.Text = model.Content;
            txtDescribe.Text = model.Describe;
            txtfileico1.Text = model.ImgUrl;
            txtKey.Text = model.StrKey;
            txtSubTitle.Text = model.SubTitle;
            txtTitle.Text = model.Title;
            ddlType.SelectedValue = model.TypeId.ToString();
            ckHot.Checked = model.IsHot == 1 ? true : false;
            ckIndex.Checked = model.IsIndex == 1 ? true : false;
            ckRec.Checked = model.IsRec == 1 ? true : false;
            ckState.Checked = model.StateInfo == 1 ? true : false;

        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.Article model = new Leadin.Model.Article();


            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }
            model.Abstract = Leadin.Common.Utils.DropHTML(txtContent.Text);
            model.Author = txtAuthor.Text;
            model.Content = txtContent.Text;
            model.Describe = txtDescribe.Text;
            model.ImgUrl = txtfileico1.Text;
            model.Introduction = txtIntroduction.Text;
            model.IsHot = ckHot.Checked ? 1 : 0;
            model.IsIndex = ckIndex.Checked ? 1 : 0;
            model.IsRec = ckRec.Checked ? 1 : 0;
            model.SourceInfo = txtSource.Text;
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.StrKey = txtKey.Text;
            model.SubTitle = txtSubTitle.Text;
            model.Title = txtTitle.Text;
            model.TypeId = int.Parse(ddlType.SelectedValue);


            if (IsEdit)
            {
                model.AddTime = DateTime.Now;
                model.Num = SetNumId("AID");

                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "资讯发布成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "资讯发布失败，请检查您的输入！", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "资讯信息编辑成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "资讯信息编辑失败，请检查您的输入！", 1000, "back");
                }
            }

        }



        /// <summary>
        /// 设置模版编号
        /// </summary>
        /// <returns></returns>
        public string SetNumId(string type)
        {

            DataSet ds = bll.GetList(0, "Num like '%" + type + "%'", "Num desc");

            if (ds.Tables[0].Rows.Count > 0)
            {

                int num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString().Replace(type, string.Empty));

                return type + (num + 1).ToString().PadLeft(8, '0');

            }
            else
            {
                return type + 1.ToString().PadLeft(8, '0');
            }

        }

    }
}
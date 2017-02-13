using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace LeadinWeb.Vanyin.Index.Template
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.IndexType bllIndexType = new Leadin.BLL.IndexType();
        Leadin.BLL.IndexTemplate bllIndex = new Leadin.BLL.IndexTemplate();
        Leadin.BLL.DesignTemplate bllTemplate = new Leadin.BLL.DesignTemplate();
        Leadin.BLL.DesignTemplateType bllTemplateType = new Leadin.BLL.DesignTemplateType();

        int tid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindIndexType();
                BindTemplateType();

                if (int.TryParse(Request.Params["id"], out tid))
                {
                    BindDetail(tid);
                }
            }
        }

        /// <summary>
        /// 绑定首页类别
        /// </summary>
        void BindIndexType()
        {
            DataSet ds = bllIndexType.GetList("ParentId=1");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlIndexType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));    
            }
        }


        /// <summary>
        /// 绑定首页显示模版的类别
        /// </summary>
        void BindTemplateType()
        {
            DataSet ds = bllTemplateType.GetList("StateInfo=1 and convert(nvarchar(255),DetailRemark)='1'");
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlTemplateType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }
        }


        /// <summary>
        /// 绑定首页模版详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.IndexTemplate model = bllIndex.GetModel(id);

            DataSet ds = bllTemplate.GetList("TypeId=" + model.ClassId + " and StateInfo=1");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlTemplate.Items.Add(new ListItem(item["Title"].ToString(),item["Id"].ToString()));
            }


            ddlIndexType.SelectedValue = model.TypeId.ToString();
            ddlTemplate.SelectedValue = model.TemplateId.ToString();
            ddlTemplateType.SelectedValue = model.ClassId.ToString();
            txtfileico1.Text = model.ImgUrl;
            txtSortNum.Text = model.SortNum.ToString();
            txtTitle.Text = model.Title;
            ckState.Checked = model.StateInfo == 1 ? true : false;



        }



        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.IndexTemplate model = new Leadin.Model.IndexTemplate();

            bool IsEdit = string.IsNullOrWhiteSpace(Request.Params["id"]);

            if (!IsEdit)
            {
                model = bllIndex.GetModel(int.Parse(Request.Params["id"]));
            }

            model.ClassId = int.Parse(ddlTemplateType.SelectedValue);
            model.ImgUrl = txtfileico1.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.TemplateId = int.Parse(Request.Form[ddlTemplate.UniqueID]);
            model.Title = txtTitle.Text ;
            model.TypeId = int.Parse(ddlIndexType.SelectedValue);


            if (IsEdit)
            {
                model.AddTime = DateTime.Now;

                if (bllIndex.Add(model) > 0)
                {
                    JsMessage("success", "首页模版添加成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "首页模版失败，请检查您的输入", 1000, "back");
                }
            }
            else
            {
                if (bllIndex.Update(model))
                {
                    JsMessage("success", "首页模版编辑成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "首页模版编辑失败，请检查您的输入", 1000, "back");
                }
            }


        }


        /// <summary>
        /// 改变模版类别加载模版
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        [System.Web.Services.WebMethod]
        public static string TemplateTypeChange(string cid)
        {

            StringBuilder strHtml = new StringBuilder();
            strHtml.Append("<option value=\"\">请选择设计模版</option>");

            if (!string.IsNullOrWhiteSpace(cid))
            {
                Leadin.BLL.DesignTemplate bllTemplateChange = new Leadin.BLL.DesignTemplate();
                DataSet ds = bllTemplateChange.GetList("TypeId=" + cid + " and StateInfo=1");

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    strHtml.Append("<option value=\""+item["Id"].ToString()+"\">"+item["Title"].ToString()+"</option>");
                }

            }

            return strHtml.ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace LeadinWeb.Vanyin.DesignTemplate.Template
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {

        Leadin.BLL.DesignTemplate bll = new Leadin.BLL.DesignTemplate();
        Leadin.BLL.DesignTemplateType blltype = new Leadin.BLL.DesignTemplateType();

        int did;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindType();
                if (int.TryParse(Request.Params["id"], out did))
                {
                    BindDetail(did);
                }
                
            }
        }


        /// <summary>
        /// 绑定设计模版类别
        /// </summary>
        void BindType()
        {
            DataTable dt = blltype.GetList("StateInfo=1 and ParentId=0").Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }


        /// <summary>
        /// 绑定模版详情
        /// </summary>
        void BindDetail(int id)
        {
            Leadin.Model.DesignTemplate model = bll.GetModel(id);

            txtContent.Text = model.DetailRemark;
            txtCycle.Text = model.Cycle;
            txtDesign.Text = model.DesignRemark;
            txtfileico1.Text = model.ImgUrl;
            txtKey.Text = model.StrKey;
            txtName.Text = model.Title;
            txtPrice.Text = model.Price;
            txtPrint.Text = model.PrintRemark;
            txtSortNum.Text = model.SortNum.ToString();
            txtTools.Text = model.Tools;
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
            Leadin.Model.DesignTemplate model = new Leadin.Model.DesignTemplate();

            bool isEdit = string.IsNullOrWhiteSpace(Request.Params["id"]);

            if (!isEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }


            model.Cycle = txtCycle.Text;
            model.DesignRemark = txtDesign.Text;
            model.DetailRemark = txtContent.Text;
            model.ImgUrl = txtfileico1.Text;
            model.IsHot = ckHot.Checked ? 1 : 0;
            model.IsIndex = ckIndex.Checked ? 1 : 0;
            model.IsRec = ckRec.Checked ? 1 : 0;    
            model.Price = txtPrice.Text;
            model.PrintRemark = txtPrint.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.StrKey = txtKey.Text;
            model.SubTitle = "";
            model.Title = txtName.Text;
            model.Tools = txtTools.Text;

            model.TypeId = int.Parse(ddlType.SelectedValue);



            if (isEdit)
            {
                model.AddTime = DateTime.Now;
                model.Num = SetNumId(blltype.GetModel(int.Parse(ddlType.SelectedValue)).Typekey);
                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "模版添加成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "模版添加失败，请检查您的输入！", 1000, "back");
                }
            }
            else
            {

                if (bll.Update(model))
                {

                    StringBuilder strUrl = new StringBuilder();


                    if (!string.IsNullOrEmpty(Request.Params["type"]))
                    {
                        strUrl.Append("&type=" + Request.Params["type"]);
                    }
                    if (!string.IsNullOrEmpty(Request.Params["keytype"]))
                    {
                        strUrl.Append("&keytype=" + Request.Params["keytype"]);
                    }
                    if (!string.IsNullOrEmpty(Request.Params["key"]))
                    {
                        strUrl.Append("&key=" + Request.Params["key"]);
                    }

                    JsMessage("success", "模版编辑成功！", 1000, "List.aspx?page="+Request.Params["page"]+strUrl.ToString());
                }

                else
                {
                    JsMessage("error", "模版编辑失败，请检查您的输入！", 1000, "back");
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

                return type + (num+1).ToString().PadLeft(8, '0');

            }
            else
            {
                return type + 1.ToString().PadLeft(8, '0');
            }

        }


        


    }
}
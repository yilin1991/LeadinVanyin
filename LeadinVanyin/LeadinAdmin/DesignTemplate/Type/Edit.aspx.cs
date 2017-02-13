using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.DesignTemplate.Type
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {

        Leadin.BLL.DesignTemplateType bll = new Leadin.BLL.DesignTemplateType();
        public int typeid;
        //public string type;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.Params["id"], out typeid))
                {
                    BindDetail(typeid);
                    Leadin.Common.Utils.WriteCookie("designtypestate","edit");

                }
                else
                {
                    Leadin.Common.Utils.WriteCookie("designtypestate", "add");
                }
            }
        }



        /// <summary>
        /// 绑定顶级类别
        /// </summary>
        //void BindType()
        //{
        //    DataSet ds = bll.GetList(0, "ParentId=0", "SortNum desc");
        //    ddlType.Items.Add(new ListItem("顶级类别", "0"));
        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
        //    }
        //}


        /// <summary>
        /// 绑定模版类别详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.DesignTemplateType  model = bll.GetModel(id);

            txtCycle.Text = model.Cycle;
            txtfileico1.Text = model.Remark.Split(',')[0];
            txtfileico2.Text = model.Remark.Split(',')[1];
            txtfileico3.Text = model.ImgUrl;
            txtPrice.Text = model.Price;
            ckHot.Checked = model.DetailRemark=="1"?true:false;
            txtSortNum.Text = model.SortNum.ToString();
            txtSubTitle.Text = model.SubTitle;
            txtTypeName.Text = model.Title;
            ckState.Checked = model.StateInfo == 1 ? true : false;
            txtKey.Text = model.Typekey;
        }


        /// <summary>
        /// 确认提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.DesignTemplateType model = new Leadin.Model.DesignTemplateType();

            bool isEdit=string.IsNullOrWhiteSpace(Request.Params["id"]);

            if (!isEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }
          

            model.Remark = txtfileico1.Text+","+txtfileico2.Text;
            model.DetailRemark = ckHot.Checked ? "1" : "0";
            model.Title = txtTypeName.Text;
            model.ParentId = 0;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.SubTitle = txtSubTitle.Text;
            model.Price = txtPrice.Text;
            model.ImgUrl = txtfileico3.Text;
            model.Cycle = txtCycle.Text;
            model.Typekey = txtKey.Text.ToUpper();


            if (isEdit)
            {
                model.AddTime = DateTime.Now;

                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "模版类别添加成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "模版类别添加失败，请检查您的输入！", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "模版类别编辑成功！", 1000, "List.aspx?page=" + Request.Params["page"] + (string.IsNullOrWhiteSpace(Request.Params["key"]) ? "" : "&key=" + Request.Params["key"]));
                }
                else
                {
                    JsMessage("error", "模版类别编辑失败，请检查您的输入！", 1000, "back");
                }
            }
        }
    }
}
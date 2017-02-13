using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Text;

namespace LeadinWeb.Vanyin.Mall.Product
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.MallType bllType = new Leadin.BLL.MallType();
        Leadin.BLL.Mall bll = new Leadin.BLL.Mall();

        public int MallId;

        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                BindType();
                if (int.TryParse(Request.Params["id"],out MallId))
                {
                    BindDetail(MallId);
                }

            }
        }


        /// <summary>
        /// 绑定商品类别
        /// </summary>
        void BindType()
        {
            DataSet ds = bllType.GetList("ParentId=0");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }



        /// <summary>
        /// 绑定商品详细信息
        /// </summary>
        void BindDetail(int id)
        {
            Leadin.Model.Mall model = bll.GetModel(id);

            txtStock.Enabled = false;


            txtContent.Text = model.Remark;
            txtfileico1.Text = model.ImgUrl;
            txtIntegral.Text = model.Integral.ToString();
            txtName.Text = model.NameInfo;
            txtPrice.Text = model.Price.ToString();
            txtSortNum.Text = model.SortNum.ToString();
            txtStock.Text = model.Stock.ToString();
            ckHot.Checked = model.IsHot == 1 ? true : false;
            ckRec.Checked = model.IsRec == 1 ? true : false;
            ckState.Checked = model.StateInfo == 1 ? true : false;
            ddlType.SelectedValue = model.MallType.ToString();


        }



        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {

            Leadin.Model.Mall model = new Leadin.Model.Mall();

            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);
            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }


            model.ImgUrl = txtfileico1.Text;
            model.Integral = int.Parse(txtIntegral.Text);
            model.IsHot = ckHot.Checked ? 1 : 0;
            model.IsRec = ckRec.Checked ? 1 : 0;
            model.MallType = int.Parse(ddlType.SelectedValue);
            model.NameInfo = txtName.Text;
        
            model.Price = decimal.Parse(txtPrice.Text);
            model.Remark = txtContent.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.Stock = int.Parse(txtStock.Text);


            if (IsEdit)
            {
                model.AddTime = DateTime.Now;
                model.Num = SetNumId("DP");
                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "兑换商品添加成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "兑换商品信息添加失败，请检查您的输入！", 1000, "back");
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
                    JsMessage("success", "兑换商品信息编辑成功！", 1000, "List.aspx?page=" + Request.Params["page"] + strUrl.ToString());
                }
                else
                {
                    JsMessage("error", "兑换商品信息编辑失败，请检查您的输入！", 1000, "back");
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
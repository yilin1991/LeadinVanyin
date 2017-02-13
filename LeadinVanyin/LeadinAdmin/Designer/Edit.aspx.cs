using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeadinWeb.Vanyin.Designer
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.Designer bll = new Leadin.BLL.Designer();

        int pid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.Params["id"], out pid))
                {
                    BindDetail(pid);
                }
            }
        }


        void BindDetail(int id)
        {
            Leadin.Model.Designer model = bll.GetModel(id);
            txtContent.Text = model.Remark;
            txtEmail.Text = model.Email;
            txtName.Text = model.NameInfo;           
            txtPhone.Text = model.Phone;
            txtAddress.Text = model.AddressInfo;
            ckState.Checked = model.StateInfo == 1 ? true : false;
        }


        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.Designer model = new Leadin.Model.Designer();

            bool isEdit = string.IsNullOrEmpty(Request.Params["id"]);
            if (!isEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }
            model.Email = txtEmail.Text;
            model.NameInfo = txtName.Text;
           
            model.Phone = txtPhone.Text;
            model.Remark = txtContent.Text;
          
            model.SortNum = 1;
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.AddressInfo = txtAddress.Text;
            if (isEdit)
            {
                model.Num = SetNumId("PID");
                model.AddTime = DateTime.Now;
                if (bll.Add(model) > 0)
                {

                    JsMessage("success", "设计师添加成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "设计师添加失败，请检查您的输入！", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "设计师信息编辑成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "设计师信息编辑失败，请检查您的输入！", 1000, "back");
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
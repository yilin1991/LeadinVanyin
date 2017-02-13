using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace LeadinWeb.Vanyin.FileInfo.FileInfo
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.Filetable bll = new Leadin.BLL.Filetable();
        Leadin.BLL.FileType blltype = new Leadin.BLL.FileType();

        int fid;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindType();
                if (int.TryParse(Request.Params["id"], out fid))
                {
                    BindDetail(fid);
                }
                
            }
        }


        /// <summary>
        /// 绑定文件类别
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
        /// 绑定文件详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.Filetable model = bll.GetModel(id);

            txtfileico1.Text = model.ImgUrl;
            txtLink.Text = model.LinkUrl;
            txtName.Text = model.Title;
            txtSortNum.Text = model.SortNum.ToString();
            ckHot.Checked = model.IsHot == 1 ? true : false;
            ckRec.Checked = model.IsRec == 1 ? true : false;
            ckState.Checked = model.StateInfo == 1 ? true : false;
            ddlType.SelectedValue = model.TypeId.ToString();
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.Filetable model = new Leadin.Model.Filetable(); 

            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);
            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }

            model.ImgUrl = txtfileico1.Text;
            model.IsHot = ckHot.Checked ? 1 : 0;
            model.IsRec = ckRec.Checked ? 1 : 0;
            model.LinkUrl = txtLink.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.Title = txtName.Text;
            model.TypeId = int.Parse(ddlType.SelectedValue);

            if (IsEdit)
            {
                model.Addtime = DateTime.Now;
                model.Num = SetNumId("FID");
                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "文件添加成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "文件添加失败，请检查您的输入", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "文件信息编辑成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "文件信息编辑失败，请检查您的输入", 1000, "back");
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
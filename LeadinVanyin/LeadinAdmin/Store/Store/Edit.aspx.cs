using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Web.Services;
using LitJson;


namespace LeadinWeb.Vanyin.Store.Store
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {

        Leadin.BLL.Store bll = new Leadin.BLL.Store();
        Leadin.BLL.StoreCity bllcity = new Leadin.BLL.StoreCity();
        Leadin.BLL.StoreType blltype = new Leadin.BLL.StoreType();

        int cid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                BindType();

                if (int.TryParse(Request.Params["id"], out cid))
                {
                    BindDetail(cid);
                }
                else
                {
                    BindCity();
                }

            }
        }

        /// <summary>
        /// 绑定门店类别
        /// </summary>
        void BindType()
        {
            DataSet ds = blltype.GetList(0,"ParentId=0 and StateInfo=1","SortNum desc,Id desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }
        }

        /// <summary>
        /// 绑定门店城市
        /// </summary>
        void BindCity()
        {
            DataSet ds = bllcity.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

            DataSet dsSub = bllcity.GetList(0, "StateInfo=1 and ParentId=" + ds.Tables[0].Rows[0]["Id"].ToString(), "SortNum desc,Id desc");

            foreach (DataRow item in dsSub.Tables[0].Rows)
            {
                ddlSubCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }

        /// <summary>
        /// 绑定门店详细信息
        /// </summary>
        /// <param name="id"></param>
        void BindDetail(int id)
        {
            Leadin.Model.Store model = bll.GetModel(id);

            txtAddress.Text = model.AddressInfo;
            txtBeginTime.Text = model.BusinessTime;
            txtContent.Text = model.Remark;
            txtfileico1.Text = model.ImgUrl;
            txtName.Text = model.Title;
            txtPayType.Text = model.PayType;
            txtScope.Text = model.Scope;
            txtSortNum.Text = model.SortNum.ToString();
            ckHot.Checked = model.IsHot == 1 ? true : false;
            ckIndex.Checked = model.IsIndex == 1 ? true : false;
            ckRec.Checked = model.IsRec == 1 ? true : false;
            ckState.Checked = model.StateInfo == 1 ? true : false;
            ddlType.SelectedValue = model.StoreType.ToString();


            int parentId = bllcity.GetModel(model.City).ParentId;

            DataSet ds = bllcity.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

            DataSet dssub = bllcity.GetList("StateInfo=1 and ParentId=" + parentId);
            ddlSubCity.Items.Clear();
            foreach (DataRow item in dssub.Tables[0].Rows)
            {
                ddlSubCity.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

            ddlSubCity.SelectedValue = model.City.ToString();
            ddlCity.SelectedValue = parentId.ToString();


        }

        /// <summary>
        /// 一级城市改变获取二级城市方法
        /// </summary>
        /// <param name="cid">一级城市编号</param>
        /// <returns></returns>
        [System.Web.Services.WebMethod]
        public static string SetChange(string cid)
        {

            Leadin.BLL.StoreCity bllcity1=new Leadin.BLL.StoreCity();
            DataSet ds = bllcity1.GetList(0,"StateInfo=1 and ParentId=" + cid,"SortNum desc,Id desc");
            StringBuilder strHtml = new StringBuilder();
         
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                strHtml.Append("<option value=\""+item["Id"].ToString()+"\">"+item["Title"].ToString()+"</option>");
            }
            return strHtml.ToString();
        }


        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.Store model = new Leadin.Model.Store();
            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }

            model.AddressInfo = txtAddress.Text;
            model.BusinessTime = txtBeginTime.Text;
            model.City = int.Parse(Request.Form[ddlSubCity.UniqueID]);
            model.ImgUrl = txtfileico1.Text;
            model.IsHot = ckHot.Checked ? 1 : 0;
            model.IsIndex = ckIndex.Checked ? 1 : 0;
            model.IsRec = ckRec.Checked ? 1 : 0;          
            model.PayType = txtPayType.Text;
            model.Remark = txtContent.Text;
            model.Scope = txtScope.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.StoreType = int.Parse(ddlType.SelectedValue);
            model.Title = txtName.Text;

            if (IsEdit)
            {
                model.Num = SetNumId("SID");
                model.AddTime = DateTime.Now;

                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "门店添加成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "门店添加失败，请检查您的输入", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "门店信息编辑成功", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "门店信息编辑失败，请检查您的输入", 1000, "back");
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
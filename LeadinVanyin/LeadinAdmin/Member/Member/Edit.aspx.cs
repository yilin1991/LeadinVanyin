using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LeadinWeb.Vanyin.Member.Member
{
    public partial class Edit : Leadin.Web.UI.ManagePage
    {
        Leadin.BLL.Member bll = new Leadin.BLL.Member();
        Leadin.BLL.MemberType blltype = new Leadin.BLL.MemberType();
        Leadin.BLL.MemberDetail blldetail = new Leadin.BLL.MemberDetail();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMemberId();
            }
        }


        /// <summary>
        /// 绑定会员类别 
        /// </summary>
        void BindMemberId()
        {
            DataSet ds = blltype.GetList(0, "StateInfo=1", "SortNum desc");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddlType.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }
        }



        /// <summary>
        /// 绑定会员详细信息
        /// </summary>
        void BindDetail(int id)
        {
            Leadin.Model.Member model = bll.GetModel(id);
            DataRow dt = blldetail.GetList("MemberId="+model.Id).Tables[0].Rows[0];


        }


        /// <summary>
        /// 提交信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.Member model = new Leadin.Model.Member();
            Leadin.Model.MemberDetail modeldetail = new Leadin.Model.MemberDetail();
            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
                modeldetail = blldetail.GetModel(int.Parse(blldetail.GetList("MemberId=" + model.Id).Tables[0].Rows[0]["Id"].ToString()));

            }


            model.Account = txtAccount.Text;
            model.Email = txtEmail.Text;
            model.HeaderImg = txtHeaderImg.Text;
           
            model.OpenId = "";
            model.Phone = txtPhone.Text;
            model.Pwd = Leadin.Common.DESEncrypt.Encrypt(txtPass.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.TypeId = int.Parse(ddlType.SelectedValue);


            modeldetail.AddressInfo = txtAddress.Text;
            modeldetail.Age = int.Parse(txtAge.Text);
            modeldetail.CompanyAddress = txtCompanyAddress.Text;
            modeldetail.CompanyName = txtCompanyName.Text;           
            modeldetail.NameInfo = txtName.Text;
            modeldetail.Position = txtPosition.Text;
            modeldetail.Remark = txtRemark.Text;
            modeldetail.Sex = rbman.Checked ? 1 : (rbwoman.Checked ? 0 : 3);
            modeldetail.SubName = txtSubName.Text;

            if (IsEdit)
            {
                model.AddTime = DateTime.Now;
                model.Num = SetNumId("VIP");


                int mid = bll.Add(model);

                modeldetail.MemberId = mid;



      

                if (mid > 0)
                {
                    if (blldetail.Add(modeldetail) > 0)
                    {
                        JsMessage("success", "会员添加成功！", 1000, "List.aspx");
                    }
                    else
                    {
                        JsMessage("error", "会员添加失败，请检查您的输入！", 1000, "back");
                    }

                }
                else
                {

                    JsMessage("error", "会员添加失败，请检查您的输入！", 1000, "back");
                }



            }

            else
            {
                if (bll.Update(model))
                {
                    if (blldetail.Update(modeldetail))
                    {
                        JsMessage("success", "会员编辑成功！", 1000, "List.aspx");
                    }
                    else
                    {
                        JsMessage("error", "会员编辑失败，请检查您的输入！", 1000, "back");
                    }
                }
                else
                {
                    JsMessage("error", "会员编辑失败，请检查您的输入！", 1000, "back");
                }
            }


        }





        /// <summary>
        /// 设置编号
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
namespace LeadinWeb.Vanyin.Member.Member
{
    public partial class List : Leadin.Web.UI.ManagePage
    {

        public int page;
        public int pagesize = 10;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.Member bll = new Leadin.BLL.Member();
        Leadin.BLL.MemberDetail bllDetail = new Leadin.BLL.MemberDetail();
        Leadin.BLL.MemberType bllType = new Leadin.BLL.MemberType();
        Leadin.BLL.view_Member bllviewmember = new Leadin.BLL.view_Member();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMemberType();
                BindRepList();
            }
        }



        /// <summary>
        /// 绑定会员类别
        /// </summary>
        void BindMemberType()
        {
            DataSet ds = bllType.GetList("ParentId=0");


            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ddltype.Items.Add(new ListItem(item["Title"].ToString(), item["Id"].ToString()));
            }

        }


        /// <summary>
        /// 绑定会员列表
        /// </summary>
        void BindRepList()
        {

            StringBuilder strWhere = new StringBuilder();



            strWhere.Append("1=1 ");

            if (!string.IsNullOrEmpty(Request.Params["type"]))
            {
                if (!string.Equals(Request.Params["type"], "0"))
                {
                    strWhere.Append(" and TypeId=" + Request.Params["type"]);
                }
                ddltype.SelectedValue = Request.Params["type"];
                strUrl.Append("&type=" + Request.Params["type"]);

            }

            if (!string.IsNullOrEmpty(Request.Params["keytype"]))
            {
                if (!string.Equals(Request.Params["keytype"], "0"))
                {
                    if (!string.IsNullOrEmpty(Request.Params["key"]))
                    {
                        switch (Request.Params["keytype"])
                        {
                            case "1":
                                strWhere.Append(" and Num ='" + Request.Params["key"] + "'");
                                break;
                            case "2":
                                strWhere.Append(" and Account like '%" + Request.Params["key"] + "%'");
                                break;
                            case "3":
                                strWhere.Append(" and Phone='" + Request.Params["key"] + "'");
                                break;
                            case "4":
                                strWhere.Append(" and (NameInfo like '%" + txtKey.Text + "' or CompanyName like '" + Request.Params["key"] + "%')");
                                break;
                        }
                    }
                    else
                    {
                        strWhere.Append(" and 1=2 ");
                    }
                }

                ddlKey.SelectedValue = Request.Params["keytype"];
                txtKey.Text = Request.Params["key"];


            }


            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }

            pcount = bllviewmember.GetRecordCount(strWhere.ToString());
            repList.DataSource = bllviewmember.GetListByPage(strWhere.ToString(), "Num desc", page * pagesize, page * pagesize + pagesize);
            repList.DataBind();

        }



        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?type=" + ddltype.SelectedValue + "&keytype=" + ddlKey.SelectedValue + "&key=" + txtKey.Text);
        }


        /// <summary>
        /// 显示全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }


        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "lbtnState")
            {
                HiddenField hidId = e.Item.FindControl("hidId") as HiddenField;
                Leadin.Model.Member model = bll.GetModel(int.Parse(hidId.Value));
                if (model.StateInfo == 1)
                {
                    model.StateInfo = 0;
                }
                else
                {
                    model.StateInfo = 1;
                }
                bll.Update(model);
            }

            BindRepList();
        }



        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDaoru_Click(object sender, EventArgs e)
        {
            if (fileExecl.FileName != "")
            {
                DataTable tblOrder = ExcelRender.RenderFromExcel(fileExecl.FileContent);


                int successNum = 0;
                int errorNum = 0;

                foreach (DataRow item in tblOrder.Rows)
                {
                    if (bll.GetList(" Account='" + item["会员帐号"].ToString() + "'").Tables[0].Rows.Count <= 0)
                    {
                        Leadin.Model.Member model = new Leadin.Model.Member();

                        model.Account = item["会员帐号"].ToString();
                        //model.AddTime = Convert.ToDateTime(item["注册时间"].ToString());
                        model.Email = item["邮箱"].ToString();
                        model.HeaderImg = "";
                        model.Num = SetNumId("VIP");
                        model.OpenId = "";
                        model.Phone = item["会员手机号"].ToString();
                        model.Pwd = Leadin.Common.DESEncrypt.Encrypt("vanyin888");
                        model.StateInfo = 1;
                        model.TypeId = 10000;
                        int mid = bll.Add(model);
                        if (mid > 0)
                        {
                            Leadin.Model.MemberDetail modeldetail = new Leadin.Model.MemberDetail();
                            modeldetail.AddressInfo = "";
                            modeldetail.Age = 0;
                            modeldetail.City = "";
                            modeldetail.CompanyAddress = item["具体地址"].ToString();
                            modeldetail.CompanyName = item["会员昵称"].ToString();
                            modeldetail.MemberId = mid;
                            modeldetail.NameInfo = item["会员真实姓名"].ToString();
                            modeldetail.Position = "";
                            modeldetail.Remark = item["项目编号"].ToString();
                            modeldetail.Sex = 1;
                            modeldetail.SubName = "";
                            if (bllDetail.Add(modeldetail) > 0)
                            {
                                successNum++;
                            }
                            else
                            {
                                errorNum++;
                            }
                        }
                        else
                        {
                            errorNum++;
                        }
                    }
                }
                JsMessage("success", "数据导入成功", 1000, "List.aspx");
            }
            else
            {
                JsMessage("error", "请选择文件", 1000, "back");

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
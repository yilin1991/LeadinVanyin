using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


namespace LeadinWeb
{
    public partial class design : System.Web.UI.Page
    {

        Leadin.BLL.DesignTemplateType bllTemplateType = new Leadin.BLL.DesignTemplateType();
        Leadin.BLL.DesignTemplate bllTemplate = new Leadin.BLL.DesignTemplate();

        DataSet dsTemplateType = new DataSet();

        public Leadin.Model.DesignTemplateType model = new Leadin.Model.DesignTemplateType();

        public string IsFirstLook = "";


        protected void Page_Load(object sender, EventArgs e)
        {

           

            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Leadin.Common.Utils.GetCookie("IsFirstLook")))
                {
                    Leadin.Common.Utils.WriteCookie("IsFirstLook", "1");
                }
                else
                {
                    IsFirstLook = "1";
                }

                BindTemplateType();
                BindTemplateTypeDetail();
                BindTemplate();

            }
        }


        /// <summary>
        /// 绑定模版类别
        /// </summary>
        void BindTemplateType()
        {
            dsTemplateType = bllTemplateType.GetList(0, "ParentId=0 and StateInfo=1", "SortNum desc,Id desc");
            repTemplateType.DataSource = dsTemplateType;
            repTemplateType.DataBind();

            repTemplateType1.DataSource = dsTemplateType;
            repTemplateType1.DataBind();

        }

        /// <summary>
        /// 绑定模版类别详情
        /// </summary>
        void BindTemplateTypeDetail()
        {
            string cid;

            if (string.IsNullOrWhiteSpace(Request.Params["type"]))
            {
                cid = dsTemplateType.Tables[0].Rows[0]["Id"].ToString();
            }
            else
            {
                cid = Request.Params["type"];
            }

            model = bllTemplateType.GetModel(int.Parse(cid));


        }


        /// <summary>
        /// 绑定设计模版
        /// </summary>
        void BindTemplate()
        {

            string cid;

            if (string.IsNullOrWhiteSpace(Request.Params["type"]))
            {
                cid = dsTemplateType.Tables[0].Rows[0]["Id"].ToString();
            }
            else
            {
                cid = Request.Params["type"];
            }
            DataSet ds = bllTemplate.GetList(16, "StateInfo=1 and TypeId=" + cid, "Addtime desc");
            repTemplate.DataSource = ds;
            repTemplate.DataBind();
        }




    }
}
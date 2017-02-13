

/**  
* tb_DesignTemplateType.cs
*
* 功 能： N/A
* 类 名： tb_DesignTemplateType
*
* Ver    变更日期             负责人    变更内容
* ───────────────────────────────────
* V0.01  2016/5/5 20:26:52    侯椅林     初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：上海领意文化传播有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/


using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Leadin.Model{
	 	/// <summary>
	///tb_DesignTemplateType
	/// </summary>
		public class DesignTemplateType
	{
   		     
      	/// <summary>
		/// 编号
        /// </summary>		
		private int _id;
        public int Id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// 类别名称
        /// </summary>		
		private string _title;
        public string Title
        {
            get{ return _title; }
            set{ _title = value; }
        }        
		/// <summary>
		/// 副标题
        /// </summary>		
		private string _subtitle;
        public string SubTitle
        {
            get{ return _subtitle; }
            set{ _subtitle = value; }
        }        
		/// <summary>
		/// 排序
        /// </summary>		
		private int _sortnum;
        public int SortNum
        {
            get{ return _sortnum; }
            set{ _sortnum = value; }
        }        
		/// <summary>
		/// 父编号
        /// </summary>		
		private int _parentid;
        public int ParentId
        {
            get{ return _parentid; }
            set{ _parentid = value; }
        }        
        /// <summary>
		/// 模版编号开头关键字
        /// </summary>		
		private string _typekey;
        public string Typekey
        {
            get { return _typekey; }
            set { _typekey = value; }
        }          
		/// <summary>
		/// 状态
        /// </summary>		
		private int _stateinfo;
        public int StateInfo
        {
            get{ return _stateinfo; }
            set{ _stateinfo = value; }
        }        
		/// <summary>
		/// 价格
        /// </summary>		
		private string _price;
        public string Price
        {
            get{ return _price; }
            set{ _price = value; }
        }        
		/// <summary>
		/// 制作周期
        /// </summary>		
		private string _cycle;
        public string Cycle
        {
            get{ return _cycle; }
            set{ _cycle = value; }
        }        
		/// <summary>
		/// 展示图片
        /// </summary>		
		private string _imgurl;
        public string ImgUrl
        {
            get{ return _imgurl; }
            set{ _imgurl = value; }
        }        
		/// <summary>
		/// 详细说明
        /// </summary>		
		private string _detailremark;
        public string DetailRemark
        {
            get{ return _detailremark; }
            set{ _detailremark = value; }
        }        
		/// <summary>
		/// 备注信息
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// 添加时间
        /// </summary>		
		private DateTime _addtime;
        public DateTime AddTime
        {
            get{ return _addtime; }
            set{ _addtime = value; }
        }        
		   
	}
}
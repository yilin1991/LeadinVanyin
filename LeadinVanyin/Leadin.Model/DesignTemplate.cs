

/**  
* tb_DesignTemplate.cs
*
* 功 能： N/A
* 类 名： tb_DesignTemplate
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
	///tb_DesignTemplate
	/// </summary>
		public class DesignTemplate
	{
   		     
      	/// <summary>
		/// 索引编号
        /// </summary>		
		private int _id;
        public int Id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// 编号
        /// </summary>		
		private string _num;
        public string Num
        {
            get{ return _num; }
            set{ _num = value; }
        }        
		/// <summary>
		/// 名称
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
		/// 关键字
        /// </summary>		
		private string _strkey;
        public string StrKey
        {
            get{ return _strkey; }
            set{ _strkey = value; }
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
		/// 设计说明
        /// </summary>		
		private string _designremark;
        public string DesignRemark
        {
            get{ return _designremark; }
            set{ _designremark = value; }
        }        
		/// <summary>
		/// 印刷说明
        /// </summary>		
		private string _printremark;
        public string PrintRemark
        {
            get{ return _printremark; }
            set{ _printremark = value; }
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
		/// 展示图片
        /// </summary>		
		private string _imgurl;
        public string ImgUrl
        {
            get{ return _imgurl; }
            set{ _imgurl = value; }
        }        
		/// <summary>
		/// 设计工具
        /// </summary>		
		private string _tools;
        public string Tools
        {
            get{ return _tools; }
            set{ _tools = value; }
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
		/// 状态1表示正常，0表示禁用
        /// </summary>		
		private int _stateinfo;
        public int StateInfo
        {
            get{ return _stateinfo; }
            set{ _stateinfo = value; }
        }        
		/// <summary>
		/// 热门模版
        /// </summary>		
		private int _ishot;
        public int IsHot
        {
            get{ return _ishot; }
            set{ _ishot = value; }
        }        
		/// <summary>
		/// 是否首页显示
        /// </summary>		
		private int _isindex;
        public int IsIndex
        {
            get{ return _isindex; }
            set{ _isindex = value; }
        }        
		/// <summary>
		/// 推荐模版
        /// </summary>		
		private int _isrec;
        public int IsRec
        {
            get{ return _isrec; }
            set{ _isrec = value; }
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
		
        /// <summary>
		/// 模版类别
        /// </summary>		
        private int _typeid;
        public int TypeId
        {
            get { return _typeid; }
            set { _typeid = value; }
        }   
            


	}
}
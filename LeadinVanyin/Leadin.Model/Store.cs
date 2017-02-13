/**  版本信息模板在安装目录下，可自行修改。
* Store.cs
*
* 功 能： N/A
* 类 名： Store
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/13 14:13:28   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Leadin.Model
{
	/// <summary>
	/// Store:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Store
	{
		public Store()
		{}
		#region Model
		private int _id;
		private string _num;
		private string _title;
		private string _addressinfo;
		private string _businesstime;
		private string _paytype;
		private string _imgurl;
		private string _scope;
		private int _city;
		private int _storetype;
		private int _stateinfo=1;
		private int _sortnum=1;
		private int _ishot=0;
		private int _isrec=0;
		private int _isindex=0;
		private string _remark;
		private DateTime _addtime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddressInfo
		{
			set{ _addressinfo=value;}
			get{return _addressinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessTime
		{
			set{ _businesstime=value;}
			get{return _businesstime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Scope
		{
			set{ _scope=value;}
			get{return _scope;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StoreType
		{
			set{ _storetype=value;}
			get{return _storetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SortNum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsRec
		{
			set{ _isrec=value;}
			get{return _isrec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsIndex
		{
			set{ _isindex=value;}
			get{return _isindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* view_IndexTemplate.cs
*
* 功 能： N/A
* 类 名： view_IndexTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/29 14:15:09   N/A    初版
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
	/// view_IndexTemplate:首页设计模版实体类
	/// </summary>
	[Serializable]
	public partial class view_IndexTemplate
	{
		public view_IndexTemplate()
		{}
		#region Model
		private int _id;
		private string _title;
		private int _typeid;
		private int _templateid;
		private int _classid;
		private string _imgurl;
		private int _stateinfo;
		private int _sortnum;
		private string _remark;
		private DateTime _addtime;
		private string _templatetypetitle;
		private int _templatetypestate;
		private string _num;
		private string _templatetitle;
		private string _price;
		private string _cycle;
		private string _templateimgurl;
		private int _templatestate;
		private string _indextypetitle;
		private int _indextypestate;
		/// <summary>
		/// 索引编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 所属类别
		/// </summary>
		public int TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 模版编号
		/// </summary>
		public int TemplateId
		{
			set{ _templateid=value;}
			get{return _templateid;}
		}
		/// <summary>
		/// 模版类别编号
		/// </summary>
		public int ClassId
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 展示图片
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 首页模版状态
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 首页模版排序
		/// </summary>
		public int SortNum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
		}
		/// <summary>
		/// 首页模版备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 首页模版添加时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 模版类别名称
		/// </summary>
		public string TemplateTypeTitle
		{
			set{ _templatetypetitle=value;}
			get{return _templatetypetitle;}
		}
		/// <summary>
		/// 模版类别状态
		/// </summary>
		public int TemplateTypeState
		{
			set{ _templatetypestate=value;}
			get{return _templatetypestate;}
		}
		/// <summary>
		/// 模版编号
		/// </summary>
		public string Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 模版名称
		/// </summary>
		public string TemplateTitle
		{
			set{ _templatetitle=value;}
			get{return _templatetitle;}
		}
		/// <summary>
		/// 模版价格
		/// </summary>
		public string Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 制作周期
		/// </summary>
		public string Cycle
		{
			set{ _cycle=value;}
			get{return _cycle;}
		}
		/// <summary>
		/// 模版办展示图片
		/// </summary>
		public string TemplateImgurl
		{
			set{ _templateimgurl=value;}
			get{return _templateimgurl;}
		}
		/// <summary>
		/// 模版状态
		/// </summary>
		public int TemplateState
		{
			set{ _templatestate=value;}
			get{return _templatestate;}
		}
		/// <summary>
		/// 首页设计模版类别名称
		/// </summary>
		public string IndexTypeTitle
		{
			set{ _indextypetitle=value;}
			get{return _indextypetitle;}
		}
		/// <summary>
		/// 首页设计模版类别状态
		/// </summary>
		public int IndexTypeState
		{
			set{ _indextypestate=value;}
			get{return _indextypestate;}
		}
		#endregion Model

	}
}


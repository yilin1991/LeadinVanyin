/**  版本信息模板在安装目录下，可自行修改。
* MemberType.cs
*
* 功 能： N/A
* 类 名： MemberType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/5/27 17:18:08   N/A    初版
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
	/// MemberType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberType
	{
		public MemberType()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _subtitle;
		private int _sortnum=0;
		private int _parentid=0;
		private int _stateinfo=1;
		private string _detailremark;
		private string _remark;
		private DateTime _addtime= DateTime.Now;
		/// <summary>
		/// 索引编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 子标题
		/// </summary>
		public string SubTitle
		{
			set{ _subtitle=value;}
			get{return _subtitle;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int SortNum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
		}
		/// <summary>
		/// 父编号
		/// </summary>
		public int ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 详细信息
		/// </summary>
		public string DetailRemark
		{
			set{ _detailremark=value;}
			get{return _detailremark;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}


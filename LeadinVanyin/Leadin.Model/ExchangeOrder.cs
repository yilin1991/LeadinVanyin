/**  版本信息模板在安装目录下，可自行修改。
* ExchangeOrder.cs
*
* 功 能： N/A
* 类 名： ExchangeOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/7 10:31:28   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ExchangeOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExchangeOrder
	{
		public ExchangeOrder()
		{}
		#region Model
		private int _id;
		private string _num;
		private int _mall;
		private int _member;
		private int _ordernum=1;
		private string _logisticscompany;
		private string _logisticsnum;
		private string _nameinfo;
		private string _tel;
		private string _addressinfo;
		private int? _integral;
		private int _stateinfo=0;
		private int _logistics=0;
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
		public int Mall
		{
			set{ _mall=value;}
			get{return _mall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Member
		{
			set{ _member=value;}
			get{return _member;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogisticsCompany
		{
			set{ _logisticscompany=value;}
			get{return _logisticscompany;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogisticsNum
		{
			set{ _logisticsnum=value;}
			get{return _logisticsnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NameInfo
		{
			set{ _nameinfo=value;}
			get{return _nameinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
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
		public int? Integral
		{
			set{ _integral=value;}
			get{return _integral;}
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
		public int Logistics
		{
			set{ _logistics=value;}
			get{return _logistics;}
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
		public DateTime Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}


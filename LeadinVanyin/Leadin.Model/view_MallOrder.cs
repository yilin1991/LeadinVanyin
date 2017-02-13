/**  版本信息模板在安装目录下，可自行修改。
* view_MallOrder.cs
*
* 功 能： N/A
* 类 名： view_MallOrder
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
	/// view_MallOrder:订单详细信息类
	/// </summary>
	[Serializable]
	public partial class view_MallOrder
	{
		public view_MallOrder()
		{}
		#region Model
		private int _id;
		private string _num;
		private int _mall;
		private int _member;
		private int _ordernum;
		private string _logisticscompany;
		private string _logisticsnum;
		private string _nameinfo;
		private string _tel;
		private string _addressinfo;
		private int? _integral;
		private int _stateinfo;
		private int _logistics;
		private string _remark;
		private DateTime _addtime;
		private string _mallnum;
		private string _mallname;
		private decimal? _price;
		private int _mallintegral;
		private string _imgurl;
		private string _membernum;
		private string _account;
		private string _phone;
		private string _email;


		/// <summary>
		/// 索引编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		public string Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public int Mall
		{
			set{ _mall=value;}
			get{return _mall;}
		}
		/// <summary>
		/// 会员编号
		/// </summary>
		public int Member
		{
			set{ _member=value;}
			get{return _member;}
		}
		/// <summary>
		/// 兑换数量
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 物流公司名称
		/// </summary>
		public string LogisticsCompany
		{
			set{ _logisticscompany=value;}
			get{return _logisticscompany;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		public string LogisticsNum
		{
			set{ _logisticsnum=value;}
			get{return _logisticsnum;}
		}
		/// <summary>
		/// 收货人姓名
		/// </summary>
		public string NameInfo
		{
			set{ _nameinfo=value;}
			get{return _nameinfo;}
		}
		/// <summary>
		/// 收货人电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 收货人地址
		/// </summary>
		public string AddressInfo
		{
			set{ _addressinfo=value;}
			get{return _addressinfo;}
		}
		/// <summary>
		/// 所需积分
		/// </summary>
		public int? Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 订单状态0表示待确认，1表示已确认，2表示已完成，3表示已取消
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 物流状态0表示等待发货，1表示配送中，2表示已签收
		/// </summary>
		public int Logistics
		{
			set{ _logistics=value;}
			get{return _logistics;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 下单时间
		/// </summary>
		public DateTime Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public string MallNum
		{
			set{ _mallnum=value;}
			get{return _mallnum;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string MallName
		{
			set{ _mallname=value;}
			get{return _mallname;}
		}
		/// <summary>
		/// 商品价格
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 商品积分
		/// </summary>
		public int MallIntegral
		{
			set{ _mallintegral=value;}
			get{return _mallintegral;}
		}
		/// <summary>
		/// 商品图片
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 会员编号
		/// </summary>
		public string MemberNum
		{
			set{ _membernum=value;}
			get{return _membernum;}
		}
		/// <summary>
		/// 会员帐号
		/// </summary>
		public string Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 会员手机号
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 会员邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* MemberDetail.cs
*
* 功 能： N/A
* 类 名： MemberDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/5/27 17:18:07   N/A    初版
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
	/// MemberDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberDetail
	{
		public MemberDetail()
		{}
		#region Model
		private int _id;
		private int _memberid;
		private int _sex=0;
		private int? _age;
		private string _companyname;
		private string _companyaddress;
		private string _position;
		private DateTime? _birthday;
		private string _nameinfo;
		private string _subname;
		private string _city;
		private string _addressinfo;
		private string _remark;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 会员编号
		/// </summary>
		public int MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public int Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 年龄
		/// </summary>
		public int? Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 公司名称
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 公司地址
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 职位
		/// </summary>
		public string Position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string NameInfo
		{
			set{ _nameinfo=value;}
			get{return _nameinfo;}
		}
		/// <summary>
		/// 别名
		/// </summary>
		public string SubName
		{
			set{ _subname=value;}
			get{return _subname;}
		}
		/// <summary>
		/// 所在城市
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 详细地址
		/// </summary>
		public string AddressInfo
		{
			set{ _addressinfo=value;}
			get{return _addressinfo;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}


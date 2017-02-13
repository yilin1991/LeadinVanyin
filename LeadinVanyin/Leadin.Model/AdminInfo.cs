

/**  
* tb_AdminInfo.cs
*
* 功 能： N/A
* 类 名： tb_AdminInfo
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
	///tb_AdminInfo
	/// </summary>
		public class AdminInfo
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
		/// 用户编号
        /// </summary>		
		private string _num;
        public string Num
        {
            get{ return _num; }
            set{ _num = value; }
        }        
		/// <summary>
		/// 帐号
        /// </summary>		
		private string _account;
        public string Account
        {
            get{ return _account; }
            set{ _account = value; }
        }        
		/// <summary>
		/// 真实姓名
        /// </summary>		
		private string _nameinfo;
        public string NameInfo
        {
            get{ return _nameinfo; }
            set{ _nameinfo = value; }
        }        
		/// <summary>
		/// 昵称
        /// </summary>		
		private string _nickname;
        public string Nickname
        {
            get{ return _nickname; }
            set{ _nickname = value; }
        }        
		/// <summary>
		/// 手机号码
        /// </summary>		
		private string _phonenum;
        public string PhoneNum
        {
            get{ return _phonenum; }
            set{ _phonenum = value; }
        }        
		/// <summary>
		/// 电话号码
        /// </summary>		
		private string _telnum;
        public string TelNum
        {
            get{ return _telnum; }
            set{ _telnum = value; }
        }        
		/// <summary>
		/// 邮箱
        /// </summary>		
		private string _emailnum;
        public string EmailNum
        {
            get{ return _emailnum; }
            set{ _emailnum = value; }
        }        
		/// <summary>
		/// 地址
        /// </summary>		
		private string _addressinfo;
        public string AddressInfo
        {
            get{ return _addressinfo; }
            set{ _addressinfo = value; }
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
		/// 状态1表示启用，0表示禁用
        /// </summary>		
		private int _stateinfo;
        public int StateInfo
        {
            get{ return _stateinfo; }
            set{ _stateinfo = value; }
        }        
		/// <summary>
		/// 上次登录时间
        /// </summary>		
		private DateTime _endlogintime;
        public DateTime EndLoginTime
        {
            get{ return _endlogintime; }
            set{ _endlogintime = value; }
        }        
		/// <summary>
		/// 最新登录时间
        /// </summary>		
		private DateTime _nowlogintime;
        public DateTime NowLoginTime
        {
            get{ return _nowlogintime; }
            set{ _nowlogintime = value; }
        }        
		/// <summary>
		/// 帐号添加时间
        /// </summary>		
		private DateTime _addtime;
        public DateTime AddTime
        {
            get{ return _addtime; }
            set{ _addtime = value; }
        }        
		/// <summary>
		/// 用户密码
        /// </summary>		
		private string _pwd;
        public string Pwd
        {
            get{ return _pwd; }
            set{ _pwd = value; }
        }        
		   
	}
}
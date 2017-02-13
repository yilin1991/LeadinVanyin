using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Leadin.Model
{
    /// <summary>
    /// 管理员类别表
    /// </summary>
    public class AdminType
    {

        /// <summary>
        /// 编号
        /// </summary>		
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>		
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// 排序
        /// </summary>		
        private int _sortnum;
        public int SortNum
        {
            get { return _sortnum; }
            set { _sortnum = value; }
        }
        /// <summary>
        /// 父编号
        /// </summary>		
        private int _parentid;
        public int ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
        }
        /// <summary>
        /// 状态1表示启用，0表示隐藏
        /// </summary>		
        private int _stateinfo;
        public int StateInfo
        {
            get { return _stateinfo; }
            set { _stateinfo = value; }
        }
        /// <summary>
        /// 备注信息
        /// </summary>		
        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>		
        private DateTime _addtime;
        public DateTime AddTime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }

    }
}


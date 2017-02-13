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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Leadin.DAL
{
	/// <summary>
	/// 数据访问类:Store
	/// </summary>
	public partial class Store
	{
		public Store()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_Store"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Store");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Leadin.Model.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Store(");
			strSql.Append("Num,Title,AddressInfo,BusinessTime,PayType,ImgUrl,Scope,City,StoreType,StateInfo,SortNum,IsHot,IsRec,IsIndex,Remark,AddTime)");
			strSql.Append(" values (");
			strSql.Append("@Num,@Title,@AddressInfo,@BusinessTime,@PayType,@ImgUrl,@Scope,@City,@StoreType,@StateInfo,@SortNum,@IsHot,@IsRec,@IsIndex,@Remark,@AddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@BusinessTime", SqlDbType.NVarChar,200),
					new SqlParameter("@PayType", SqlDbType.NVarChar,200),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Scope", SqlDbType.NVarChar,200),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@StoreType", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsRec", SqlDbType.Int,4),
					new SqlParameter("@IsIndex", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@AddTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.AddressInfo;
			parameters[3].Value = model.BusinessTime;
			parameters[4].Value = model.PayType;
			parameters[5].Value = model.ImgUrl;
			parameters[6].Value = model.Scope;
			parameters[7].Value = model.City;
			parameters[8].Value = model.StoreType;
			parameters[9].Value = model.StateInfo;
			parameters[10].Value = model.SortNum;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsRec;
			parameters[13].Value = model.IsIndex;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.AddTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Store set ");
			strSql.Append("Num=@Num,");
			strSql.Append("Title=@Title,");
			strSql.Append("AddressInfo=@AddressInfo,");
			strSql.Append("BusinessTime=@BusinessTime,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("Scope=@Scope,");
			strSql.Append("City=@City,");
			strSql.Append("StoreType=@StoreType,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("SortNum=@SortNum,");
			strSql.Append("IsHot=@IsHot,");
			strSql.Append("IsRec=@IsRec,");
			strSql.Append("IsIndex=@IsIndex,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("AddTime=@AddTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@BusinessTime", SqlDbType.NVarChar,200),
					new SqlParameter("@PayType", SqlDbType.NVarChar,200),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Scope", SqlDbType.NVarChar,200),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@StoreType", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsRec", SqlDbType.Int,4),
					new SqlParameter("@IsIndex", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.AddressInfo;
			parameters[3].Value = model.BusinessTime;
			parameters[4].Value = model.PayType;
			parameters[5].Value = model.ImgUrl;
			parameters[6].Value = model.Scope;
			parameters[7].Value = model.City;
			parameters[8].Value = model.StoreType;
			parameters[9].Value = model.StateInfo;
			parameters[10].Value = model.SortNum;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsRec;
			parameters[13].Value = model.IsIndex;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.AddTime;
			parameters[16].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Store ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Store ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.Store GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Num,Title,AddressInfo,BusinessTime,PayType,ImgUrl,Scope,City,StoreType,StateInfo,SortNum,IsHot,IsRec,IsIndex,Remark,AddTime from tb_Store ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Leadin.Model.Store model=new Leadin.Model.Store();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.Store DataRowToModel(DataRow row)
		{
			Leadin.Model.Store model=new Leadin.Model.Store();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Num"]!=null)
				{
					model.Num=row["Num"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["AddressInfo"]!=null)
				{
					model.AddressInfo=row["AddressInfo"].ToString();
				}
				if(row["BusinessTime"]!=null)
				{
					model.BusinessTime=row["BusinessTime"].ToString();
				}
				if(row["PayType"]!=null)
				{
					model.PayType=row["PayType"].ToString();
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["Scope"]!=null)
				{
					model.Scope=row["Scope"].ToString();
				}
				if(row["City"]!=null && row["City"].ToString()!="")
				{
					model.City=int.Parse(row["City"].ToString());
				}
				if(row["StoreType"]!=null && row["StoreType"].ToString()!="")
				{
					model.StoreType=int.Parse(row["StoreType"].ToString());
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["SortNum"]!=null && row["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(row["SortNum"].ToString());
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
				}
				if(row["IsRec"]!=null && row["IsRec"].ToString()!="")
				{
					model.IsRec=int.Parse(row["IsRec"].ToString());
				}
				if(row["IsIndex"]!=null && row["IsIndex"].ToString()!="")
				{
					model.IsIndex=int.Parse(row["IsIndex"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Num,Title,AddressInfo,BusinessTime,PayType,ImgUrl,Scope,City,StoreType,StateInfo,SortNum,IsHot,IsRec,IsIndex,Remark,AddTime ");
			strSql.Append(" FROM tb_Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Num,Title,AddressInfo,BusinessTime,PayType,ImgUrl,Scope,City,StoreType,StateInfo,SortNum,IsHot,IsRec,IsIndex,Remark,AddTime ");
			strSql.Append(" FROM tb_Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_Store T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_Store";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}


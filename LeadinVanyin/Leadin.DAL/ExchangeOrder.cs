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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ExchangeOrder
	/// </summary>
	public partial class ExchangeOrder
	{
		public ExchangeOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_ExchangeOrder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_ExchangeOrder");
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
		public int Add(Maticsoft.Model.ExchangeOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_ExchangeOrder(");
			strSql.Append("Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime)");
			strSql.Append(" values (");
			strSql.Append("@Num,@Mall,@Member,@OrderNum,@LogisticsCompany,@LogisticsNum,@NameInfo,@Tel,@AddressInfo,@Integral,@StateInfo,@Logistics,@Remark,@Addtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Mall", SqlDbType.Int,4),
					new SqlParameter("@Member", SqlDbType.Int,4),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@LogisticsCompany", SqlDbType.NVarChar,100),
					new SqlParameter("@LogisticsNum", SqlDbType.NVarChar,100),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@Tel", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@Logistics", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@Addtime", SqlDbType.DateTime)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Mall;
			parameters[2].Value = model.Member;
			parameters[3].Value = model.OrderNum;
			parameters[4].Value = model.LogisticsCompany;
			parameters[5].Value = model.LogisticsNum;
			parameters[6].Value = model.NameInfo;
			parameters[7].Value = model.Tel;
			parameters[8].Value = model.AddressInfo;
			parameters[9].Value = model.Integral;
			parameters[10].Value = model.StateInfo;
			parameters[11].Value = model.Logistics;
			parameters[12].Value = model.Remark;
			parameters[13].Value = model.Addtime;

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
		public bool Update(Maticsoft.Model.ExchangeOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_ExchangeOrder set ");
			strSql.Append("Num=@Num,");
			strSql.Append("Mall=@Mall,");
			strSql.Append("Member=@Member,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("LogisticsCompany=@LogisticsCompany,");
			strSql.Append("LogisticsNum=@LogisticsNum,");
			strSql.Append("NameInfo=@NameInfo,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("AddressInfo=@AddressInfo,");
			strSql.Append("Integral=@Integral,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("Logistics=@Logistics,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Addtime=@Addtime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Mall", SqlDbType.Int,4),
					new SqlParameter("@Member", SqlDbType.Int,4),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@LogisticsCompany", SqlDbType.NVarChar,100),
					new SqlParameter("@LogisticsNum", SqlDbType.NVarChar,100),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@Tel", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Integral", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@Logistics", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Mall;
			parameters[2].Value = model.Member;
			parameters[3].Value = model.OrderNum;
			parameters[4].Value = model.LogisticsCompany;
			parameters[5].Value = model.LogisticsNum;
			parameters[6].Value = model.NameInfo;
			parameters[7].Value = model.Tel;
			parameters[8].Value = model.AddressInfo;
			parameters[9].Value = model.Integral;
			parameters[10].Value = model.StateInfo;
			parameters[11].Value = model.Logistics;
			parameters[12].Value = model.Remark;
			parameters[13].Value = model.Addtime;
			parameters[14].Value = model.Id;

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
			strSql.Append("delete from tb_ExchangeOrder ");
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
			strSql.Append("delete from tb_ExchangeOrder ");
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
		public Maticsoft.Model.ExchangeOrder GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime from tb_ExchangeOrder ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.ExchangeOrder model=new Maticsoft.Model.ExchangeOrder();
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
		public Maticsoft.Model.ExchangeOrder DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ExchangeOrder model=new Maticsoft.Model.ExchangeOrder();
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
				if(row["Mall"]!=null && row["Mall"].ToString()!="")
				{
					model.Mall=int.Parse(row["Mall"].ToString());
				}
				if(row["Member"]!=null && row["Member"].ToString()!="")
				{
					model.Member=int.Parse(row["Member"].ToString());
				}
				if(row["OrderNum"]!=null && row["OrderNum"].ToString()!="")
				{
					model.OrderNum=int.Parse(row["OrderNum"].ToString());
				}
				if(row["LogisticsCompany"]!=null)
				{
					model.LogisticsCompany=row["LogisticsCompany"].ToString();
				}
				if(row["LogisticsNum"]!=null)
				{
					model.LogisticsNum=row["LogisticsNum"].ToString();
				}
				if(row["NameInfo"]!=null)
				{
					model.NameInfo=row["NameInfo"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["AddressInfo"]!=null)
				{
					model.AddressInfo=row["AddressInfo"].ToString();
				}
				if(row["Integral"]!=null && row["Integral"].ToString()!="")
				{
					model.Integral=int.Parse(row["Integral"].ToString());
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["Logistics"]!=null && row["Logistics"].ToString()!="")
				{
					model.Logistics=int.Parse(row["Logistics"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Addtime"]!=null && row["Addtime"].ToString()!="")
				{
					model.Addtime=DateTime.Parse(row["Addtime"].ToString());
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
			strSql.Append("select Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime ");
			strSql.Append(" FROM tb_ExchangeOrder ");
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
			strSql.Append(" Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime ");
			strSql.Append(" FROM tb_ExchangeOrder ");
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
			strSql.Append("select count(1) FROM tb_ExchangeOrder ");
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
			strSql.Append(")AS Row, T.*  from tb_ExchangeOrder T ");
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
			parameters[0].Value = "tb_ExchangeOrder";
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


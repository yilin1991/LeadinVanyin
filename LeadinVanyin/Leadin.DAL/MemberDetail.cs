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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Leadin.DAL
{
	/// <summary>
	/// 数据访问类:MemberDetail
	/// </summary>
	public partial class MemberDetail
	{
		public MemberDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_MemberDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_MemberDetail");
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
		public int Add(Leadin.Model.MemberDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_MemberDetail(");
			strSql.Append("MemberId,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark)");
			strSql.Append(" values (");
			strSql.Append("@MemberId,@Sex,@Age,@CompanyName,@CompanyAddress,@Position,@Birthday,@NameInfo,@SubName,@City,@AddressInfo,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.Int,4),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Age", SqlDbType.Int,4),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,200),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@Position", SqlDbType.NVarChar,200),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@SubName", SqlDbType.NVarChar,100),
					new SqlParameter("@City", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Remark", SqlDbType.NText)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.Sex;
			parameters[2].Value = model.Age;
			parameters[3].Value = model.CompanyName;
			parameters[4].Value = model.CompanyAddress;
			parameters[5].Value = model.Position;
			parameters[6].Value = model.Birthday;
			parameters[7].Value = model.NameInfo;
			parameters[8].Value = model.SubName;
			parameters[9].Value = model.City;
			parameters[10].Value = model.AddressInfo;
			parameters[11].Value = model.Remark;

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
		public bool Update(Leadin.Model.MemberDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_MemberDetail set ");
			strSql.Append("MemberId=@MemberId,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Age=@Age,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("Position=@Position,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("NameInfo=@NameInfo,");
			strSql.Append("SubName=@SubName,");
			strSql.Append("City=@City,");
			strSql.Append("AddressInfo=@AddressInfo,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.Int,4),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Age", SqlDbType.Int,4),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,200),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@Position", SqlDbType.NVarChar,200),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@SubName", SqlDbType.NVarChar,100),
					new SqlParameter("@City", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.Sex;
			parameters[2].Value = model.Age;
			parameters[3].Value = model.CompanyName;
			parameters[4].Value = model.CompanyAddress;
			parameters[5].Value = model.Position;
			parameters[6].Value = model.Birthday;
			parameters[7].Value = model.NameInfo;
			parameters[8].Value = model.SubName;
			parameters[9].Value = model.City;
			parameters[10].Value = model.AddressInfo;
			parameters[11].Value = model.Remark;
			parameters[12].Value = model.Id;

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
			strSql.Append("delete from tb_MemberDetail ");
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
			strSql.Append("delete from tb_MemberDetail ");
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
		public Leadin.Model.MemberDetail GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,MemberId,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark from tb_MemberDetail ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Leadin.Model.MemberDetail model=new Leadin.Model.MemberDetail();
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
		public Leadin.Model.MemberDetail DataRowToModel(DataRow row)
		{
			Leadin.Model.MemberDetail model=new Leadin.Model.MemberDetail();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["MemberId"]!=null && row["MemberId"].ToString()!="")
				{
					model.MemberId=int.Parse(row["MemberId"].ToString());
				}
				if(row["Sex"]!=null && row["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(row["Sex"].ToString());
				}
				if(row["Age"]!=null && row["Age"].ToString()!="")
				{
					model.Age=int.Parse(row["Age"].ToString());
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["Position"]!=null)
				{
					model.Position=row["Position"].ToString();
				}
				if(row["Birthday"]!=null && row["Birthday"].ToString()!="")
				{
					model.Birthday=DateTime.Parse(row["Birthday"].ToString());
				}
				if(row["NameInfo"]!=null)
				{
					model.NameInfo=row["NameInfo"].ToString();
				}
				if(row["SubName"]!=null)
				{
					model.SubName=row["SubName"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["AddressInfo"]!=null)
				{
					model.AddressInfo=row["AddressInfo"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select Id,MemberId,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark ");
			strSql.Append(" FROM tb_MemberDetail ");
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
			strSql.Append(" Id,MemberId,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark ");
			strSql.Append(" FROM tb_MemberDetail ");
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
			strSql.Append("select count(1) FROM tb_MemberDetail ");
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
			strSql.Append(")AS Row, T.*  from tb_MemberDetail T ");
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
			parameters[0].Value = "tb_MemberDetail";
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


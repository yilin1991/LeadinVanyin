/**  版本信息模板在安装目录下，可自行修改。
* view_Member.cs
*
* 功 能： N/A
* 类 名： view_Member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/1 18:03:05   N/A    初版
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
	/// 数据访问类:view_Member
	/// </summary>
	public partial class view_Member
	{
		public view_Member()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Leadin.Model.view_Member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into view_Member(");
			strSql.Append("Id,Num,Account,Pwd,Phone,Email,TypeId,StateInfo,HeaderImg,OpenId,AddTime,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Num,@Account,@Pwd,@Phone,@Email,@TypeId,@StateInfo,@HeaderImg,@OpenId,@AddTime,@Sex,@Age,@CompanyName,@CompanyAddress,@Position,@Birthday,@NameInfo,@SubName,@City,@AddressInfo,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@HeaderImg", SqlDbType.NVarChar,200),
					new SqlParameter("@OpenId", SqlDbType.NVarChar,200),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
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
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.Account;
			parameters[3].Value = model.Pwd;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.TypeId;
			parameters[7].Value = model.StateInfo;
			parameters[8].Value = model.HeaderImg;
			parameters[9].Value = model.OpenId;
			parameters[10].Value = model.AddTime;
			parameters[11].Value = model.Sex;
			parameters[12].Value = model.Age;
			parameters[13].Value = model.CompanyName;
			parameters[14].Value = model.CompanyAddress;
			parameters[15].Value = model.Position;
			parameters[16].Value = model.Birthday;
			parameters[17].Value = model.NameInfo;
			parameters[18].Value = model.SubName;
			parameters[19].Value = model.City;
			parameters[20].Value = model.AddressInfo;
			parameters[21].Value = model.Remark;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.view_Member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update view_Member set ");
			strSql.Append("Id=@Id,");
			strSql.Append("Num=@Num,");
			strSql.Append("Account=@Account,");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Email=@Email,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("HeaderImg=@HeaderImg,");
			strSql.Append("OpenId=@OpenId,");
			strSql.Append("AddTime=@AddTime,");
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
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,100),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@HeaderImg", SqlDbType.NVarChar,200),
					new SqlParameter("@OpenId", SqlDbType.NVarChar,200),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
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
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.Account;
			parameters[3].Value = model.Pwd;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.TypeId;
			parameters[7].Value = model.StateInfo;
			parameters[8].Value = model.HeaderImg;
			parameters[9].Value = model.OpenId;
			parameters[10].Value = model.AddTime;
			parameters[11].Value = model.Sex;
			parameters[12].Value = model.Age;
			parameters[13].Value = model.CompanyName;
			parameters[14].Value = model.CompanyAddress;
			parameters[15].Value = model.Position;
			parameters[16].Value = model.Birthday;
			parameters[17].Value = model.NameInfo;
			parameters[18].Value = model.SubName;
			parameters[19].Value = model.City;
			parameters[20].Value = model.AddressInfo;
			parameters[21].Value = model.Remark;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from view_Member ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.view_Member GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Num,Account,Pwd,Phone,Email,TypeId,StateInfo,HeaderImg,OpenId,AddTime,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark from view_Member ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Leadin.Model.view_Member model=new Leadin.Model.view_Member();
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
		public Leadin.Model.view_Member DataRowToModel(DataRow row)
		{
			Leadin.Model.view_Member model=new Leadin.Model.view_Member();
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
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["TypeId"]!=null && row["TypeId"].ToString()!="")
				{
					model.TypeId=int.Parse(row["TypeId"].ToString());
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["HeaderImg"]!=null)
				{
					model.HeaderImg=row["HeaderImg"].ToString();
				}
				if(row["OpenId"]!=null)
				{
					model.OpenId=row["OpenId"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
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
			strSql.Append("select Id,Num,Account,Pwd,Phone,Email,TypeId,StateInfo,HeaderImg,OpenId,AddTime,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark ");
			strSql.Append(" FROM view_Member ");
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
			strSql.Append(" Id,Num,Account,Pwd,Phone,Email,TypeId,StateInfo,HeaderImg,OpenId,AddTime,Sex,Age,CompanyName,CompanyAddress,Position,Birthday,NameInfo,SubName,City,AddressInfo,Remark ");
			strSql.Append(" FROM view_Member ");
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
			strSql.Append("select count(1) FROM view_Member ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from view_Member T ");
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
			parameters[0].Value = "view_Member";
			parameters[1].Value = "";
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


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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Leadin.DAL
{
	/// <summary>
	/// 数据访问类:view_MallOrder
	/// </summary>
	public partial class view_MallOrder
	{
		public view_MallOrder()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.view_MallOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into view_MallOrder(");
			strSql.Append("Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime,MallNum,MallName,Price,MallIntegral,ImgUrl,MemberNum,Account,Phone,Email)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Num,@Mall,@Member,@OrderNum,@LogisticsCompany,@LogisticsNum,@NameInfo,@Tel,@AddressInfo,@Integral,@StateInfo,@Logistics,@Remark,@Addtime,@MallNum,@MallName,@Price,@MallIntegral,@ImgUrl,@MemberNum,@Account,@Phone,@Email)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
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
					new SqlParameter("@MallNum", SqlDbType.NVarChar,100),
					new SqlParameter("@MallName", SqlDbType.NVarChar,200),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MallIntegral", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@MemberNum", SqlDbType.NVarChar,100),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.Mall;
			parameters[3].Value = model.Member;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.LogisticsCompany;
			parameters[6].Value = model.LogisticsNum;
			parameters[7].Value = model.NameInfo;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.AddressInfo;
			parameters[10].Value = model.Integral;
			parameters[11].Value = model.StateInfo;
			parameters[12].Value = model.Logistics;
			parameters[13].Value = model.Remark;
			parameters[14].Value = model.Addtime;
			parameters[15].Value = model.MallNum;
			parameters[16].Value = model.MallName;
			parameters[17].Value = model.Price;
			parameters[18].Value = model.MallIntegral;
			parameters[19].Value = model.ImgUrl;
			parameters[20].Value = model.MemberNum;
			parameters[21].Value = model.Account;
			parameters[22].Value = model.Phone;
			parameters[23].Value = model.Email;

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
		public bool Update(Maticsoft.Model.view_MallOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update view_MallOrder set ");
			strSql.Append("Id=@Id,");
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
			strSql.Append("Addtime=@Addtime,");
			strSql.Append("MallNum=@MallNum,");
			strSql.Append("MallName=@MallName,");
			strSql.Append("Price=@Price,");
			strSql.Append("MallIntegral=@MallIntegral,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("MemberNum=@MemberNum,");
			strSql.Append("Account=@Account,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Email=@Email");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
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
					new SqlParameter("@MallNum", SqlDbType.NVarChar,100),
					new SqlParameter("@MallName", SqlDbType.NVarChar,200),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@MallIntegral", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@MemberNum", SqlDbType.NVarChar,100),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.Mall;
			parameters[3].Value = model.Member;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.LogisticsCompany;
			parameters[6].Value = model.LogisticsNum;
			parameters[7].Value = model.NameInfo;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.AddressInfo;
			parameters[10].Value = model.Integral;
			parameters[11].Value = model.StateInfo;
			parameters[12].Value = model.Logistics;
			parameters[13].Value = model.Remark;
			parameters[14].Value = model.Addtime;
			parameters[15].Value = model.MallNum;
			parameters[16].Value = model.MallName;
			parameters[17].Value = model.Price;
			parameters[18].Value = model.MallIntegral;
			parameters[19].Value = model.ImgUrl;
			parameters[20].Value = model.MemberNum;
			parameters[21].Value = model.Account;
			parameters[22].Value = model.Phone;
			parameters[23].Value = model.Email;

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
			strSql.Append("delete from view_MallOrder ");
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
		public Maticsoft.Model.view_MallOrder GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime,MallNum,MallName,Price,MallIntegral,ImgUrl,MemberNum,Account,Phone,Email from view_MallOrder ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.view_MallOrder model=new Maticsoft.Model.view_MallOrder();
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
		public Maticsoft.Model.view_MallOrder DataRowToModel(DataRow row)
		{
			Maticsoft.Model.view_MallOrder model=new Maticsoft.Model.view_MallOrder();
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
				if(row["MallNum"]!=null)
				{
					model.MallNum=row["MallNum"].ToString();
				}
				if(row["MallName"]!=null)
				{
					model.MallName=row["MallName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["MallIntegral"]!=null && row["MallIntegral"].ToString()!="")
				{
					model.MallIntegral=int.Parse(row["MallIntegral"].ToString());
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["MemberNum"]!=null)
				{
					model.MemberNum=row["MemberNum"].ToString();
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
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
			strSql.Append("select Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime,MallNum,MallName,Price,MallIntegral,ImgUrl,MemberNum,Account,Phone,Email ");
			strSql.Append(" FROM view_MallOrder ");
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
			strSql.Append(" Id,Num,Mall,Member,OrderNum,LogisticsCompany,LogisticsNum,NameInfo,Tel,AddressInfo,Integral,StateInfo,Logistics,Remark,Addtime,MallNum,MallName,Price,MallIntegral,ImgUrl,MemberNum,Account,Phone,Email ");
			strSql.Append(" FROM view_MallOrder ");
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
			strSql.Append("select count(1) FROM view_MallOrder ");
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
			strSql.Append(")AS Row, T.*  from view_MallOrder T ");
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
			parameters[0].Value = "view_MallOrder";
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


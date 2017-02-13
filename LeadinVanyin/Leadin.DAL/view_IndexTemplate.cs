/**  版本信息模板在安装目录下，可自行修改。
* view_IndexTemplate.cs
*
* 功 能： N/A
* 类 名： view_IndexTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/29 14:15:09   N/A    初版
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
	/// 数据访问类:view_IndexTemplate
	/// </summary>
	public partial class view_IndexTemplate
	{
		public view_IndexTemplate()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Leadin.Model.view_IndexTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into view_IndexTemplate(");
			strSql.Append("Id,Title,TypeId,TemplateId,ClassId,ImgUrl,StateInfo,SortNum,Remark,AddTime,TemplateTypeTitle,TemplateTypeState,Num,TemplateTitle,Price,Cycle,TemplateImgurl,TemplateState,IndexTypeTitle,IndexTypeState)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Title,@TypeId,@TemplateId,@ClassId,@ImgUrl,@StateInfo,@SortNum,@Remark,@AddTime,@TemplateTypeTitle,@TemplateTypeState,@Num,@TemplateTitle,@Price,@Cycle,@TemplateImgurl,@TemplateState,@IndexTypeTitle,@IndexTypeState)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@TemplateId", SqlDbType.Int,4),
					new SqlParameter("@ClassId", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateTypeTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@TemplateTypeState", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@Price", SqlDbType.NVarChar,100),
					new SqlParameter("@Cycle", SqlDbType.NVarChar,100),
					new SqlParameter("@TemplateImgurl", SqlDbType.NVarChar,200),
					new SqlParameter("@TemplateState", SqlDbType.Int,4),
					new SqlParameter("@IndexTypeTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@IndexTypeState", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.TypeId;
			parameters[3].Value = model.TemplateId;
			parameters[4].Value = model.ClassId;
			parameters[5].Value = model.ImgUrl;
			parameters[6].Value = model.StateInfo;
			parameters[7].Value = model.SortNum;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.AddTime;
			parameters[10].Value = model.TemplateTypeTitle;
			parameters[11].Value = model.TemplateTypeState;
			parameters[12].Value = model.Num;
			parameters[13].Value = model.TemplateTitle;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.Cycle;
			parameters[16].Value = model.TemplateImgurl;
			parameters[17].Value = model.TemplateState;
			parameters[18].Value = model.IndexTypeTitle;
			parameters[19].Value = model.IndexTypeState;

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
		public bool Update(Leadin.Model.view_IndexTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update view_IndexTemplate set ");
			strSql.Append("Id=@Id,");
			strSql.Append("Title=@Title,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("TemplateId=@TemplateId,");
			strSql.Append("ClassId=@ClassId,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("SortNum=@SortNum,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("TemplateTypeTitle=@TemplateTypeTitle,");
			strSql.Append("TemplateTypeState=@TemplateTypeState,");
			strSql.Append("Num=@Num,");
			strSql.Append("TemplateTitle=@TemplateTitle,");
			strSql.Append("Price=@Price,");
			strSql.Append("Cycle=@Cycle,");
			strSql.Append("TemplateImgurl=@TemplateImgurl,");
			strSql.Append("TemplateState=@TemplateState,");
			strSql.Append("IndexTypeTitle=@IndexTypeTitle,");
			strSql.Append("IndexTypeState=@IndexTypeState");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@TemplateId", SqlDbType.Int,4),
					new SqlParameter("@ClassId", SqlDbType.Int,4),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateTypeTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@TemplateTypeState", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateTitle", SqlDbType.NVarChar,200),
					new SqlParameter("@Price", SqlDbType.NVarChar,100),
					new SqlParameter("@Cycle", SqlDbType.NVarChar,100),
					new SqlParameter("@TemplateImgurl", SqlDbType.NVarChar,200),
					new SqlParameter("@TemplateState", SqlDbType.Int,4),
					new SqlParameter("@IndexTypeTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@IndexTypeState", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.TypeId;
			parameters[3].Value = model.TemplateId;
			parameters[4].Value = model.ClassId;
			parameters[5].Value = model.ImgUrl;
			parameters[6].Value = model.StateInfo;
			parameters[7].Value = model.SortNum;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.AddTime;
			parameters[10].Value = model.TemplateTypeTitle;
			parameters[11].Value = model.TemplateTypeState;
			parameters[12].Value = model.Num;
			parameters[13].Value = model.TemplateTitle;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.Cycle;
			parameters[16].Value = model.TemplateImgurl;
			parameters[17].Value = model.TemplateState;
			parameters[18].Value = model.IndexTypeTitle;
			parameters[19].Value = model.IndexTypeState;

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
			strSql.Append("delete from view_IndexTemplate ");
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
		public Leadin.Model.view_IndexTemplate GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Title,TypeId,TemplateId,ClassId,ImgUrl,StateInfo,SortNum,Remark,AddTime,TemplateTypeTitle,TemplateTypeState,Num,TemplateTitle,Price,Cycle,TemplateImgurl,TemplateState,IndexTypeTitle,IndexTypeState from view_IndexTemplate ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Leadin.Model.view_IndexTemplate model=new Leadin.Model.view_IndexTemplate();
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
		public Leadin.Model.view_IndexTemplate DataRowToModel(DataRow row)
		{
			Leadin.Model.view_IndexTemplate model=new Leadin.Model.view_IndexTemplate();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["TypeId"]!=null && row["TypeId"].ToString()!="")
				{
					model.TypeId=int.Parse(row["TypeId"].ToString());
				}
				if(row["TemplateId"]!=null && row["TemplateId"].ToString()!="")
				{
					model.TemplateId=int.Parse(row["TemplateId"].ToString());
				}
				if(row["ClassId"]!=null && row["ClassId"].ToString()!="")
				{
					model.ClassId=int.Parse(row["ClassId"].ToString());
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["SortNum"]!=null && row["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(row["SortNum"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["TemplateTypeTitle"]!=null)
				{
					model.TemplateTypeTitle=row["TemplateTypeTitle"].ToString();
				}
				if(row["TemplateTypeState"]!=null && row["TemplateTypeState"].ToString()!="")
				{
					model.TemplateTypeState=int.Parse(row["TemplateTypeState"].ToString());
				}
				if(row["Num"]!=null)
				{
					model.Num=row["Num"].ToString();
				}
				if(row["TemplateTitle"]!=null)
				{
					model.TemplateTitle=row["TemplateTitle"].ToString();
				}
				if(row["Price"]!=null)
				{
					model.Price=row["Price"].ToString();
				}
				if(row["Cycle"]!=null)
				{
					model.Cycle=row["Cycle"].ToString();
				}
				if(row["TemplateImgurl"]!=null)
				{
					model.TemplateImgurl=row["TemplateImgurl"].ToString();
				}
				if(row["TemplateState"]!=null && row["TemplateState"].ToString()!="")
				{
					model.TemplateState=int.Parse(row["TemplateState"].ToString());
				}
				if(row["IndexTypeTitle"]!=null)
				{
					model.IndexTypeTitle=row["IndexTypeTitle"].ToString();
				}
				if(row["IndexTypeState"]!=null && row["IndexTypeState"].ToString()!="")
				{
					model.IndexTypeState=int.Parse(row["IndexTypeState"].ToString());
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
			strSql.Append("select Id,Title,TypeId,TemplateId,ClassId,ImgUrl,StateInfo,SortNum,Remark,AddTime,TemplateTypeTitle,TemplateTypeState,Num,TemplateTitle,Price,Cycle,TemplateImgurl,TemplateState,IndexTypeTitle,IndexTypeState ");
			strSql.Append(" FROM view_IndexTemplate ");
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
			strSql.Append(" Id,Title,TypeId,TemplateId,ClassId,ImgUrl,StateInfo,SortNum,Remark,AddTime,TemplateTypeTitle,TemplateTypeState,Num,TemplateTitle,Price,Cycle,TemplateImgurl,TemplateState,IndexTypeTitle,IndexTypeState ");
			strSql.Append(" FROM view_IndexTemplate ");
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
			strSql.Append("select count(1) FROM view_IndexTemplate ");
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
			strSql.Append(")AS Row, T.*  from view_IndexTemplate T ");
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
			parameters[0].Value = "view_IndexTemplate";
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


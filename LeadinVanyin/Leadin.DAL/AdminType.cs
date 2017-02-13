using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.DBUtility;
namespace Leadin.DAL  
{
	 	//tb_AdminType
		public partial class AdminType
	{
   		     
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_AdminType");
			strSql.Append(" where ");
			                                       strSql.Append(" Id = @Id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Leadin.Model.AdminType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_AdminType(");			
            strSql.Append("Title,SortNum,ParentId,StateInfo,Remark,AddTime");
			strSql.Append(") values (");
            strSql.Append("@Title,@SortNum,@ParentId,@StateInfo,@Remark,@AddTime");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@Title", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@ParentId", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@AddTime", SqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.Title;                        
            parameters[1].Value = model.SortNum;                        
            parameters[2].Value = model.ParentId;                        
            parameters[3].Value = model.StateInfo;                        
            parameters[4].Value = model.Remark;                        
            parameters[5].Value = model.AddTime;                        
			   
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
		public bool Update(Leadin.Model.AdminType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_AdminType set ");
			                                                
            strSql.Append(" Title = @Title , ");                                    
            strSql.Append(" SortNum = @SortNum , ");                                    
            strSql.Append(" ParentId = @ParentId , ");                                    
            strSql.Append(" StateInfo = @StateInfo , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" AddTime = @AddTime  ");            			
			strSql.Append(" where Id=@Id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@Id", SqlDbType.Int,4) ,            
                        new SqlParameter("@Title", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@ParentId", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@AddTime", SqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.Id;                        
            parameters[1].Value = model.Title;                        
            parameters[2].Value = model.SortNum;                        
            parameters[3].Value = model.ParentId;                        
            parameters[4].Value = model.StateInfo;                        
            parameters[5].Value = model.Remark;                        
            parameters[6].Value = model.AddTime;                        
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
			strSql.Append("delete from tb_AdminType ");
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
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_AdminType ");
			strSql.Append(" where ID in ("+Idlist + ")  ");
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
		public Leadin.Model.AdminType GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id, Title, SortNum, ParentId, StateInfo, Remark, AddTime  ");			
			strSql.Append("  from tb_AdminType ");
			strSql.Append(" where Id=@Id");
						SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			
			Leadin.Model.AdminType model=new Leadin.Model.AdminType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
																																				model.Title= ds.Tables[0].Rows[0]["Title"].ToString();
																												if(ds.Tables[0].Rows[0]["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(ds.Tables[0].Rows[0]["SortNum"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["ParentId"].ToString()!="")
				{
					model.ParentId=int.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(ds.Tables[0].Rows[0]["StateInfo"].ToString());
				}
																																				model.Remark= ds.Tables[0].Rows[0]["Remark"].ToString();
																												if(ds.Tables[0].Rows[0]["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(ds.Tables[0].Rows[0]["AddTime"].ToString());
				}
																														
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tb_AdminType ");
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
			strSql.Append(" * ");
			strSql.Append(" FROM tb_AdminType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

       
 
        /// <summary>
		///  分页获取数据
		/// </summary>
        public DataSet GetPageList(int pageSize, int currentPage, string strWhere, string filedOrder)
        {

            int topSize = pageSize * currentPage;
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select top " + pageSize + " * from tb_AdminType");
            strSql.Append(" where Id not in(select top " + topSize + " Id from tb_AdminType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + ")");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);

            return DbHelperSQL.Query(strSql.ToString());

        }
   
	}
}


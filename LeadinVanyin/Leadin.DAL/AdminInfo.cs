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
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.DBUtility;
namespace Leadin.DAL  
{
	 	//tb_AdminInfo
		public partial class AdminInfo
	{
   		     
		public bool Exists(int Id,string Num,string Account)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_AdminInfo");
			strSql.Append(" where ");
			                                       strSql.Append(" Id = @Id and  ");
                                                                   strSql.Append(" Num = @Num and  ");
                                                                   strSql.Append(" Account = @Account  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Account", SqlDbType.NVarChar,100)			};
			parameters[0].Value = Id;
			parameters[1].Value = Num;
			parameters[2].Value = Account;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Leadin.Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_AdminInfo(");			
            strSql.Append("Num,Account,NameInfo,Nickname,PhoneNum,TelNum,EmailNum,AddressInfo,SortNum,StateInfo,EndLoginTime,NowLoginTime,AddTime,Pwd");
			strSql.Append(") values (");
            strSql.Append("@Num,@Account,@NameInfo,@Nickname,@PhoneNum,@TelNum,@EmailNum,@AddressInfo,@SortNum,@StateInfo,@EndLoginTime,@NowLoginTime,@AddTime,@Pwd");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@Num", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Account", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@NameInfo", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Nickname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@PhoneNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@TelNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@EmailNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@EndLoginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@NowLoginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@AddTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@Pwd", SqlDbType.NVarChar,100)             
              
            };
			            
            parameters[0].Value = model.Num;                        
            parameters[1].Value = model.Account;                        
            parameters[2].Value = model.NameInfo;                        
            parameters[3].Value = model.Nickname;                        
            parameters[4].Value = model.PhoneNum;                        
            parameters[5].Value = model.TelNum;                        
            parameters[6].Value = model.EmailNum;                        
            parameters[7].Value = model.AddressInfo;                        
            parameters[8].Value = model.SortNum;                        
            parameters[9].Value = model.StateInfo;                        
            parameters[10].Value = model.EndLoginTime;                        
            parameters[11].Value = model.NowLoginTime;                        
            parameters[12].Value = model.AddTime;                        
            parameters[13].Value = model.Pwd;                        
			   
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
		public bool Update(Leadin.Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_AdminInfo set ");
			                                                
            strSql.Append(" Num = @Num , ");                                    
            strSql.Append(" Account = @Account , ");                                    
            strSql.Append(" NameInfo = @NameInfo , ");                                    
            strSql.Append(" Nickname = @Nickname , ");                                    
            strSql.Append(" PhoneNum = @PhoneNum , ");                                    
            strSql.Append(" TelNum = @TelNum , ");                                    
            strSql.Append(" EmailNum = @EmailNum , ");                                    
            strSql.Append(" AddressInfo = @AddressInfo , ");                                    
            strSql.Append(" SortNum = @SortNum , ");                                    
            strSql.Append(" StateInfo = @StateInfo , ");                                    
            strSql.Append(" EndLoginTime = @EndLoginTime , ");                                    
            strSql.Append(" NowLoginTime = @NowLoginTime , ");                                    
            strSql.Append(" AddTime = @AddTime , ");                                    
            strSql.Append(" Pwd = @Pwd  ");            			
			strSql.Append(" where Id=@Id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@Id", SqlDbType.Int,4) ,            
                        new SqlParameter("@Num", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Account", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@NameInfo", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Nickname", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@PhoneNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@TelNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@EmailNum", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@EndLoginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@NowLoginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@AddTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@Pwd", SqlDbType.NVarChar,100)             
              
            };
						            
            parameters[0].Value = model.Id;                        
            parameters[1].Value = model.Num;                        
            parameters[2].Value = model.Account;                        
            parameters[3].Value = model.NameInfo;                        
            parameters[4].Value = model.Nickname;                        
            parameters[5].Value = model.PhoneNum;                        
            parameters[6].Value = model.TelNum;                        
            parameters[7].Value = model.EmailNum;                        
            parameters[8].Value = model.AddressInfo;                        
            parameters[9].Value = model.SortNum;                        
            parameters[10].Value = model.StateInfo;                        
            parameters[11].Value = model.EndLoginTime;                        
            parameters[12].Value = model.NowLoginTime;                        
            parameters[13].Value = model.AddTime;                        
            parameters[14].Value = model.Pwd;                        
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
			strSql.Append("delete from tb_AdminInfo ");
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
			strSql.Append("delete from tb_AdminInfo ");
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
		public Leadin.Model.AdminInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id, Num, Account, NameInfo, Nickname, PhoneNum, TelNum, EmailNum, AddressInfo, SortNum, StateInfo, EndLoginTime, NowLoginTime, AddTime, Pwd  ");			
			strSql.Append("  from tb_AdminInfo ");
			strSql.Append(" where Id=@Id");
						SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			
			Leadin.Model.AdminInfo model=new Leadin.Model.AdminInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
																																				model.Num= ds.Tables[0].Rows[0]["Num"].ToString();
																																model.Account= ds.Tables[0].Rows[0]["Account"].ToString();
																																model.NameInfo= ds.Tables[0].Rows[0]["NameInfo"].ToString();
																																model.Nickname= ds.Tables[0].Rows[0]["Nickname"].ToString();
																																model.PhoneNum= ds.Tables[0].Rows[0]["PhoneNum"].ToString();
																																model.TelNum= ds.Tables[0].Rows[0]["TelNum"].ToString();
																																model.EmailNum= ds.Tables[0].Rows[0]["EmailNum"].ToString();
																																model.AddressInfo= ds.Tables[0].Rows[0]["AddressInfo"].ToString();
																												if(ds.Tables[0].Rows[0]["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(ds.Tables[0].Rows[0]["SortNum"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(ds.Tables[0].Rows[0]["StateInfo"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["EndLoginTime"].ToString()!="")
				{
					model.EndLoginTime=DateTime.Parse(ds.Tables[0].Rows[0]["EndLoginTime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["NowLoginTime"].ToString()!="")
				{
					model.NowLoginTime=DateTime.Parse(ds.Tables[0].Rows[0]["NowLoginTime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(ds.Tables[0].Rows[0]["AddTime"].ToString());
				}
																																				model.Pwd= ds.Tables[0].Rows[0]["Pwd"].ToString();
																										
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
			strSql.Append(" FROM tb_AdminInfo ");
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
			strSql.Append(" FROM tb_AdminInfo ");
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

            strSql.Append("select top " + pageSize + " * from tb_AdminInfo");
            strSql.Append(" where Id not in(select top " + topSize + " Id from tb_AdminInfo ");
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


/**  
* tb_DesignTemplate.cs
*
* 功 能： N/A
* 类 名： tb_DesignTemplate
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
    //tb_DesignTemplate
    public partial class DesignTemplate
    {

        public bool Exists(int Id, string Num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_DesignTemplate");
            strSql.Append(" where ");
            strSql.Append(" Id = @Id and  ");
            strSql.Append(" Num = @Num  ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50)			};
            parameters[0].Value = Id;
            parameters[1].Value = Num;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Leadin.Model.DesignTemplate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_DesignTemplate(");
            strSql.Append("Num,Title,SubTitle,StrKey,Price,Cycle,DesignRemark,PrintRemark,DetailRemark,ImgUrl,Tools,SortNum,StateInfo,IsHot,IsIndex,IsRec,AddTime,TypeId");
            strSql.Append(") values (");
            strSql.Append("@Num,@Title,@SubTitle,@StrKey,@Price,@Cycle,@DesignRemark,@PrintRemark,@DetailRemark,@ImgUrl,@Tools,@SortNum,@StateInfo,@IsHot,@IsIndex,@IsRec,@AddTime,@TypeId");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@Num", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Title", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SubTitle", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@StrKey", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Price", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Cycle", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@DesignRemark", SqlDbType.NText) ,            
                        new SqlParameter("@PrintRemark", SqlDbType.NText) ,            
                        new SqlParameter("@DetailRemark", SqlDbType.NText) ,            
                        new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Tools", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsHot", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsIndex", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsRec", SqlDbType.Int,4) ,            
                        new SqlParameter("@AddTime", SqlDbType.DateTime),
                        new SqlParameter("@TypeId",SqlDbType.Int,4)
              
            };

            parameters[0].Value = model.Num;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.SubTitle;
            parameters[3].Value = model.StrKey;
            parameters[4].Value = model.Price;
            parameters[5].Value = model.Cycle;
            parameters[6].Value = model.DesignRemark;
            parameters[7].Value = model.PrintRemark;
            parameters[8].Value = model.DetailRemark;
            parameters[9].Value = model.ImgUrl;
            parameters[10].Value = model.Tools;
            parameters[11].Value = model.SortNum;
            parameters[12].Value = model.StateInfo;
            parameters[13].Value = model.IsHot;
            parameters[14].Value = model.IsIndex;
            parameters[15].Value = model.IsRec;
            parameters[16].Value = model.AddTime;
            parameters[17].Value = model.TypeId;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Leadin.Model.DesignTemplate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_DesignTemplate set ");

            strSql.Append(" Num = @Num , ");
            strSql.Append(" Title = @Title , ");
            strSql.Append(" SubTitle = @SubTitle , ");
            strSql.Append(" StrKey = @StrKey , ");
            strSql.Append(" Price = @Price , ");
            strSql.Append(" Cycle = @Cycle , ");
            strSql.Append(" DesignRemark = @DesignRemark , ");
            strSql.Append(" PrintRemark = @PrintRemark , ");
            strSql.Append(" DetailRemark = @DetailRemark , ");
            strSql.Append(" ImgUrl = @ImgUrl , ");
            strSql.Append(" Tools = @Tools , ");
            strSql.Append(" SortNum = @SortNum , ");
            strSql.Append(" StateInfo = @StateInfo , ");
            strSql.Append(" IsHot = @IsHot , ");
            strSql.Append(" IsIndex = @IsIndex , ");
            strSql.Append(" IsRec = @IsRec , ");
            strSql.Append(" AddTime = @AddTime,TypeId=@TypeId  ");
            strSql.Append(" where Id=@Id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@Id", SqlDbType.Int,4) ,            
                        new SqlParameter("@Num", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Title", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SubTitle", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@StrKey", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Price", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Cycle", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@DesignRemark", SqlDbType.NText) ,            
                        new SqlParameter("@PrintRemark", SqlDbType.NText) ,            
                        new SqlParameter("@DetailRemark", SqlDbType.NText) ,            
                        new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Tools", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@SortNum", SqlDbType.Int,4) ,            
                        new SqlParameter("@StateInfo", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsHot", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsIndex", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsRec", SqlDbType.Int,4) ,  
                        new SqlParameter("@TypeId",SqlDbType.Int,4),
                        new SqlParameter("@AddTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.Id;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.SubTitle;
            parameters[4].Value = model.StrKey;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.Cycle;
            parameters[7].Value = model.DesignRemark;
            parameters[8].Value = model.PrintRemark;
            parameters[9].Value = model.DetailRemark;
            parameters[10].Value = model.ImgUrl;
            parameters[11].Value = model.Tools;
            parameters[12].Value = model.SortNum;
            parameters[13].Value = model.StateInfo;
            parameters[14].Value = model.IsHot;
            parameters[15].Value = model.IsIndex;
            parameters[16].Value = model.IsRec;
            parameters[17].Value = model.TypeId;
            parameters[18].Value = model.AddTime;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_DesignTemplate ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_DesignTemplate ");
            strSql.Append(" where ID in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Leadin.Model.DesignTemplate GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, Num, Title, SubTitle, StrKey, Price, Cycle, DesignRemark, PrintRemark, DetailRemark, ImgUrl, Tools, SortNum, StateInfo, IsHot, IsIndex, IsRec, AddTime,TypeId  ");
            strSql.Append("  from tb_DesignTemplate ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;


            Leadin.Model.DesignTemplate model = new Leadin.Model.DesignTemplate();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                model.Num = ds.Tables[0].Rows[0]["Num"].ToString();
                model.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                model.SubTitle = ds.Tables[0].Rows[0]["SubTitle"].ToString();
                model.StrKey = ds.Tables[0].Rows[0]["StrKey"].ToString();
                model.Price = ds.Tables[0].Rows[0]["Price"].ToString();
                model.Cycle = ds.Tables[0].Rows[0]["Cycle"].ToString();
                model.DesignRemark = ds.Tables[0].Rows[0]["DesignRemark"].ToString();
                model.PrintRemark = ds.Tables[0].Rows[0]["PrintRemark"].ToString();
                model.DetailRemark = ds.Tables[0].Rows[0]["DetailRemark"].ToString();
                model.ImgUrl = ds.Tables[0].Rows[0]["ImgUrl"].ToString();
                model.Tools = ds.Tables[0].Rows[0]["Tools"].ToString();

                if (ds.Tables[0].Rows[0]["TypeId"].ToString() != "")
                {
                    model.TypeId = int.Parse(ds.Tables[0].Rows[0]["TypeId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SortNum"].ToString() != "")
                {
                    model.SortNum = int.Parse(ds.Tables[0].Rows[0]["SortNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StateInfo"].ToString() != "")
                {
                    model.StateInfo = int.Parse(ds.Tables[0].Rows[0]["StateInfo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsHot"].ToString() != "")
                {
                    model.IsHot = int.Parse(ds.Tables[0].Rows[0]["IsHot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsIndex"].ToString() != "")
                {
                    model.IsIndex = int.Parse(ds.Tables[0].Rows[0]["IsIndex"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsRec"].ToString() != "")
                {
                    model.IsRec = int.Parse(ds.Tables[0].Rows[0]["IsRec"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AddTime"].ToString() != "")
                {
                    model.AddTime = DateTime.Parse(ds.Tables[0].Rows[0]["AddTime"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_DesignTemplate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM tb_DesignTemplate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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

            strSql.Append("select top " + pageSize + " * from tb_DesignTemplate");
            strSql.Append(" where Id not in(select top " + topSize + " Id from tb_DesignTemplate ");
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


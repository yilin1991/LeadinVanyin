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
using System.Collections.Generic; 
using System.Data;
using Leadin.Common;
using Leadin.Model;
namespace Leadin.BLL {
	 	//tb_DesignTemplate
		public partial class DesignTemplate
	{
   		     
		private readonly Leadin.DAL.DesignTemplate dal=new Leadin.DAL.DesignTemplate();
		public DesignTemplate()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id,string Num)
		{
			return dal.Exists(Id,Num);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Leadin.Model.DesignTemplate model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.DesignTemplate model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.DesignTemplate GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		
		/// <summary>
		///  分页获取数据
		/// </summary>
		 public DataSet GetPageList(int pageSize, int currentPage, string strWhere, string filedOrder)
        {
            return dal.GetPageList(pageSize, currentPage, strWhere, filedOrder);
        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Leadin.Model.DesignTemplate> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Leadin.Model.DesignTemplate> DataTableToList(DataTable dt)
		{
			List<Leadin.Model.DesignTemplate> modelList = new List<Leadin.Model.DesignTemplate>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Leadin.Model.DesignTemplate model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Leadin.Model.DesignTemplate();					
													if(dt.Rows[n]["Id"].ToString()!="")
				{
					model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
				}
																																				model.Num= dt.Rows[n]["Num"].ToString();
																																model.Title= dt.Rows[n]["Title"].ToString();
																																model.SubTitle= dt.Rows[n]["SubTitle"].ToString();
																																model.StrKey= dt.Rows[n]["StrKey"].ToString();
																																model.Price= dt.Rows[n]["Price"].ToString();
																																model.Cycle= dt.Rows[n]["Cycle"].ToString();
																																model.DesignRemark= dt.Rows[n]["DesignRemark"].ToString();
																																model.PrintRemark= dt.Rows[n]["PrintRemark"].ToString();
																																model.DetailRemark= dt.Rows[n]["DetailRemark"].ToString();
																																model.ImgUrl= dt.Rows[n]["ImgUrl"].ToString();
																																model.Tools= dt.Rows[n]["Tools"].ToString();
																												if(dt.Rows[n]["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(dt.Rows[n]["SortNum"].ToString());
				}
																																if(dt.Rows[n]["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(dt.Rows[n]["StateInfo"].ToString());
				}
																																if(dt.Rows[n]["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(dt.Rows[n]["IsHot"].ToString());
				}
																																if(dt.Rows[n]["IsIndex"].ToString()!="")
				{
					model.IsIndex=int.Parse(dt.Rows[n]["IsIndex"].ToString());
				}
																																if(dt.Rows[n]["IsRec"].ToString()!="")
				{
					model.IsRec=int.Parse(dt.Rows[n]["IsRec"].ToString());
				}
																																if(dt.Rows[n]["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(dt.Rows[n]["AddTime"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
		}
		
		
		
		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}
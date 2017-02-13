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
using System.Collections.Generic; 
using System.Data;
using Leadin.Common;
using Leadin.Model;
namespace Leadin.BLL {
	 	//tb_AdminInfo
		public partial class AdminInfo
	{
   		     
		private readonly Leadin.DAL.AdminInfo dal=new Leadin.DAL.AdminInfo();
		public AdminInfo()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id,string Num,string Account)
		{
			return dal.Exists(Id,Num,Account);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Leadin.Model.AdminInfo model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.AdminInfo model)
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
		public Leadin.Model.AdminInfo GetModel(int Id)
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
		public List<Leadin.Model.AdminInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Leadin.Model.AdminInfo> DataTableToList(DataTable dt)
		{
			List<Leadin.Model.AdminInfo> modelList = new List<Leadin.Model.AdminInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Leadin.Model.AdminInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Leadin.Model.AdminInfo();					
													if(dt.Rows[n]["Id"].ToString()!="")
				{
					model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
				}
																																				model.Num= dt.Rows[n]["Num"].ToString();
																																model.Account= dt.Rows[n]["Account"].ToString();
																																model.NameInfo= dt.Rows[n]["NameInfo"].ToString();
																																model.Nickname= dt.Rows[n]["Nickname"].ToString();
																																model.PhoneNum= dt.Rows[n]["PhoneNum"].ToString();
																																model.TelNum= dt.Rows[n]["TelNum"].ToString();
																																model.EmailNum= dt.Rows[n]["EmailNum"].ToString();
																																model.AddressInfo= dt.Rows[n]["AddressInfo"].ToString();
																												if(dt.Rows[n]["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(dt.Rows[n]["SortNum"].ToString());
				}
																																if(dt.Rows[n]["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(dt.Rows[n]["StateInfo"].ToString());
				}
																																if(dt.Rows[n]["EndLoginTime"].ToString()!="")
				{
					model.EndLoginTime=DateTime.Parse(dt.Rows[n]["EndLoginTime"].ToString());
				}
																																if(dt.Rows[n]["NowLoginTime"].ToString()!="")
				{
					model.NowLoginTime=DateTime.Parse(dt.Rows[n]["NowLoginTime"].ToString());
				}
																																if(dt.Rows[n]["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(dt.Rows[n]["AddTime"].ToString());
				}
																																				model.Pwd= dt.Rows[n]["Pwd"].ToString();
																						
				
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
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Leadin.Common;
using Leadin.Model;
namespace Leadin.BLL {
	 	//tb_AdminType
		public partial class AdminType
	{
   		     
		private readonly Leadin.DAL.AdminType dal=new Leadin.DAL.AdminType();
		public AdminType()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Leadin.Model.AdminType model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.AdminType model)
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
		public Leadin.Model.AdminType GetModel(int Id)
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
		public List<Leadin.Model.AdminType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Leadin.Model.AdminType> DataTableToList(DataTable dt)
		{
			List<Leadin.Model.AdminType> modelList = new List<Leadin.Model.AdminType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Leadin.Model.AdminType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Leadin.Model.AdminType();					
													if(dt.Rows[n]["Id"].ToString()!="")
				{
					model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
				}
																																				model.Title= dt.Rows[n]["Title"].ToString();
																												if(dt.Rows[n]["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(dt.Rows[n]["SortNum"].ToString());
				}
																																if(dt.Rows[n]["ParentId"].ToString()!="")
				{
					model.ParentId=int.Parse(dt.Rows[n]["ParentId"].ToString());
				}
																																if(dt.Rows[n]["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(dt.Rows[n]["StateInfo"].ToString());
				}
																																				model.Remark= dt.Rows[n]["Remark"].ToString();
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
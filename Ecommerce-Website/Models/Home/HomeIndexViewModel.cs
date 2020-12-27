using Ecommerce_Website.DAL;
using Ecommerce_Website.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Ecommerce_Website.Models.Home
{
    
        //public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();

        //public IEnumerable<Tbl_Product> ListofProducts { get; set; }


        //public static HomeIndexViewModel CreateModel()
        //{
        //    return new HomeIndexViewModel
        //    {
        //        ListofProducts = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecords() 
        //    };
        //}
    public class HomeIndexViewModel
    {
        dbMyOnlineShoppingEntities context = new dbMyOnlineShoppingEntities();
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pagesize ,int? page)
            {

                SqlParameter[] param = new SqlParameter[] {
                   new SqlParameter("@search",search??(object)DBNull.Value)
                 };
                IPagedList<Tbl_Product> data =context.Database.SqlQuery<Tbl_Product>("GetBySearch @search",param).ToList().ToPagedList(page ?? 1, pagesize);
          
                return new HomeIndexViewModel
                {
                    ListOfProducts = data
                };
            }
    }
}
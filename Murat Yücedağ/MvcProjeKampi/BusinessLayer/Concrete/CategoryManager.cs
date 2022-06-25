using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new DataAccessLayer.Repositories.GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }
        public void CategoryAddBl(Category category)
        {
            //if (category.CategoryName =="" || category.CategoryName.Length<=3||
            //    category.CategoryDescription=="" || category.CategoryName.Length >=51)
            //{
            //    //Hata mesajı
            //}
            //else
            //{
            //    repo.Insert(category);
            //}
            repo.Insert(category);
        }
    }
}

using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryValues = categoryManager.GetAllBl();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()//Sayfa açılırken devreye girecek
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)//Sayfada butona tıklanırsa devreye girecek
        {
            categoryManager.CategoryAddBl(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}
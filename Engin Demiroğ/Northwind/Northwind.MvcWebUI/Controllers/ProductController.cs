using Microsoft.AspNetCore.Mvc;
using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
        public ViewResult Index()
        {
            return View(_productManager.GetAll());
        }

    }
}

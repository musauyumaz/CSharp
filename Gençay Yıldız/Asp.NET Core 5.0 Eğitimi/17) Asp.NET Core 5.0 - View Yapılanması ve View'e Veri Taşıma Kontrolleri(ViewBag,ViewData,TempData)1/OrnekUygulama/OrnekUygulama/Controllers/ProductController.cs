using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id=1,ProductName="A Product",Quantity=10},
                new Product{Id=2,ProductName="B Product",Quantity=15},
                new Product{Id=3,ProductName="C Product",Quantity=20}
            };
            #region Model Bazlı Veri Gönderimi
            //return View(products);
            #endregion
            #region Veri Taşıma Kontrolleri 
            #region ViewBag
            //View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür 
            //ViewBag.products = products;
            //Datayı dynamic şekilde taşır
            #endregion
            #region ViewData
            //ViewBag'de olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür.
            ViewData["products"] = products;
            //Datayı Boxing ederek taşır View'de tekrardan unboxing etmelisin
            #endregion
            #region TempData
            //ViewData'da olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür.

            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;
            //Actionlar arası veri taşımamızı sağlayan bir veri taşıma kontrolüdür İlgili tarayıcı üstünde cookieleri sayesinde bu verileri taşıyabilmektedir
            //TempData["x"] = 5;
            //ViewData["x"] = 5;
            //ViewBag.x = 5;
            #endregion
            #endregion
            return RedirectToAction("Index2", "Product");
        }
        public IActionResult Index2()
        {
            //var v1 = ViewBag.x;
            //var v2 = ViewData["x"];
            //var v3 = TempData["x"];
            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            return View();
        }
    }
}

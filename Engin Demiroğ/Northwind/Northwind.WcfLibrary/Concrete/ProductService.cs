using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        //Instance Provider ile ezilecek
        private ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
             _productManager.Update(product);
        }
    }
}

using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        NorthwindContext _context = new NorthwindContext();
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            var productToDelete = _context.Products.Where(p => p.ProductID == productId).FirstOrDefault();
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _context.Products.Where(p=>p.ProductID==productId).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            var productToUpdate = _context.Products.Where(p => p.ProductID == product.ProductID).FirstOrDefault();
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            _context.SaveChanges();

        }
    }
}

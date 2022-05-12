using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);
    }
}

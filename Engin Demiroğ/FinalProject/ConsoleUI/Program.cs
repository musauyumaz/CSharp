using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Transformation Object
//SOLID
//Single Responsibility
//Open Closed Principle - sisteme yeni birşey eklenirken mevcuttaki hiçbir koda dokunma
//IoC

 static void ProductTest()
{
    
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetAll();
    if (result.Success==true)
    {
     foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
   
}
static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }

}
ProductTest();
//CategoryTest();
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Concrete.Dtos;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

foreach (Customer customer in customerManager.GetAll().Data)
{
    Console.WriteLine(customer.Id);
}


//Car car1 = new Car {Id=6,BrandId=6,ColorId=3,DailyPrice=700,ModelYear=2013,Description="KIA BONGO"};

//carManager.Add(car1);
//car1.Description = "MUSA";
//carManager.Update(car1);
//carManager.Delete(car1);
//Console.WriteLine(carManager.GetById(6).Description); 

//foreach (CarDetailsDto car in carManager.GetCarDetails().Data)
//{
//    Console.WriteLine(car.Id + " / " + car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
//}
//Console.WriteLine(customerManager.GetAll().Data.Count); 
//customerManager.Add(new Customer {FirstName="Engin",LastName="Demiroğ",CompanyName="Kodlama io",Email="engindemirog@gmail.com",Password="12345"});

//foreach (Color color in colorManager.GetAll().Data)
//{
//    Console.WriteLine(color.ColorName);
//}
//Console.WriteLine(colorManager.GetAll().Message);
//Console.WriteLine(brandManager.GetAll().Message);
//foreach (Brand brand in brandManager.GetAll().Data)
//{
//    Console.WriteLine(brand.BrandName);
//}
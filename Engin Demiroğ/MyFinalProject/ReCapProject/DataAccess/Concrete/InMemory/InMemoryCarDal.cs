using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=250000,ModelYear=2021,Description="SİYAH AUDİ A8"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=350000,ModelYear=2020,Description="BEYAZ AUDİ Q7"},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=500000,ModelYear=2019,Description="GÜMÜŞ BMW X6"},
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=725000,ModelYear=2018,Description="SİYAH BMW M5"},
                new Car{Id=5,BrandId=3,ColorId=4,DailyPrice=925000,ModelYear=2017,Description="KIRMIZI FERRARİ"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c=>c.Id == CarId).ToList() ;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

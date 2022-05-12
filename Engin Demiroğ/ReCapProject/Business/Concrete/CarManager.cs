using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _iCarDal.Add(car);
                return new SuccessResult(car.CarName + Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.NameInvalid);
            }

        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new SuccessResult(car.CarName + Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(c => c.Id == carId), Messages.Listed);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_iCarDal.GetCarDetails(), Messages.ListedDetails);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.BrandId == brandId), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.ColorId == colorId), Messages.Listed);
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new SuccessResult(car.CarName + Messages.Updated);
        }


    }
}

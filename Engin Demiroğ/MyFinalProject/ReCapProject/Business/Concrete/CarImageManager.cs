using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carimage)
        {
            _carImageDal.Add(carimage);
           return new SuccessResult ();
        }

        public IResult Delete(CarImage carimage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetImageById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carimage)
        {
            throw new NotImplementedException();
        }
    }
}

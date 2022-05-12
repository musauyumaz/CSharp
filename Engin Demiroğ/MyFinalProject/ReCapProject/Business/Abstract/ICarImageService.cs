using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<CarImage> GetImageById(int id);
        IResult Delete (CarImage carimage);
        IResult Update (CarImage carimage);
        IResult Add (CarImage carimage);
    }
}

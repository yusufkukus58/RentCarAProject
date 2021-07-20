using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

        IResult add(Car entity);
        IResult delete(Car entity);
        IResult update(Car entity);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult TransactionalOperation(Car car);


    }
}

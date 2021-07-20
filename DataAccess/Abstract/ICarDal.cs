using Core.DataAccess;
using Core.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICarDal: IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();
    }
}

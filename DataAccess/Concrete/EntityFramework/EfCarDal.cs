﻿using Core.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Context context= new Context())
            {
                var result = from c in context.Cars
                             join co in context.Colors on c.ColorId equals co.Id
                           join b in context.Brands on c.BrandId equals b.Id
                           select new CarDetailDto { 
                           CarId=c.Id,
                           CarName=b.BrandName,
                           BrandName=b.BrandName,
                           ColorName=co.ColorName,
                           DailyPrice=c.DailyPrice

                           
                           };
                return result.ToList();

            }
        }
    }
}

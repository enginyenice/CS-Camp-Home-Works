using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfRepositoryBase<Car, EfContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetail()
        {
            using (EfContext context = new EfContext())
            {
                var result = from p in context.Car
                             join c in context.Color
                             on p.ColorId equals c.ColorId
                             join d in context.Brand
                             on p.BrandId equals d.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = d.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear,
                                 CarId = p.CarId
                             };
                return result.ToList();
            }
        }
    }
}
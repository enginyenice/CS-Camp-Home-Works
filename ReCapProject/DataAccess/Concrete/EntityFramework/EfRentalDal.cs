using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfRepositoryBase<Rental, EfContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetails()
        {
            using (EfContext context = new EfContext())
            {
                var result = from rental in context.Rental

                             join customer in context.Customer
                             on rental.CustomerId equals customer.Id

                             join user in context.User
                             on customer.UserId equals user.Id

                             join car in context.Car
                             on rental.CarId equals car.Id

                             join brand in context.Brand
                             on car.BrandId equals brand.Id

                             join color in context.Color
                             on car.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 RentalId = rental.Id,
                                 BrandName = brand.BrandName,
                                 CarDesctiption = car.Description,
                                 ColorName = color.ColorName,
                                 CompanyName = customer.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
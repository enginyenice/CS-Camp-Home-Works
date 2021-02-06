using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private readonly List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=55,ModelYear=1998,Description="Car Item 1"},
                new Car {CarId=2,BrandId=2,ColorId=2,DailyPrice=55,ModelYear=1998,Description="Car Item 2"},
                new Car {CarId=3,BrandId=3,ColorId=3,DailyPrice=55,ModelYear=1998,Description="Car Item 3"},
                new Car {CarId=4,BrandId=4,ColorId=4,DailyPrice=55,ModelYear=1998,Description="Car Item 4"}
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car DeleteOfCar = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
            _cars.Remove(DeleteOfCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.CarId == id);
        }

        public List<CarDetailDto> GetCarsDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car UpdateOfCar = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
            UpdateOfCar.BrandId = entity.BrandId;
            UpdateOfCar.ColorId = entity.ColorId;
            UpdateOfCar.DailyPrice = entity.DailyPrice;
            UpdateOfCar.Description = entity.Description;
        }
    }
}
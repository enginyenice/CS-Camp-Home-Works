using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.Description.Length >= 2 && entity.DailyPrice > 0)
                _carDal.Add(entity);
            else
                Console.WriteLine("Araba açıklaması en az 2 karakterden oluşmalıdır.\nGünlük fiyatı 0 liradan büyük olmalıdır.");
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public Car Get(int id)
        {
            return _carDal.Get(p => p.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarsDetail()
        {
            return _carDal.GetCarsDetail();
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
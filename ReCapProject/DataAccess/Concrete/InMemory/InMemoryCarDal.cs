using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private readonly List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 55, ModelYear=2013, Description="Temiz araç" },
            new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 40, ModelYear=1993, Description="Ağır hasar kaydı var." }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(DeleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car UpdateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            UpdateToCar.BrandId = car.BrandId;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.DailyPrice = car.DailyPrice;
            UpdateToCar.ModelYear = car.ModelYear;
        }
    }
}
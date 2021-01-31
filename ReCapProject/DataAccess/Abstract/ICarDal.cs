using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        /*
         *  GetById, GetAll, Add, Update, Delete
         */

        Car GetById(int id);

        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
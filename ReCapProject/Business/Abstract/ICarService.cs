using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailDto> GetCarsDetail();
    }
}
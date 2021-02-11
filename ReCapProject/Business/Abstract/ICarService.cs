using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        DataResult<List<Car>> GetCarsByBrandId(int brandId);

        DataResult<List<Car>> GetCarsByColorId(int colorId);

        DataResult<List<CarDetailDto>> GetCarsDetail();
    }
}
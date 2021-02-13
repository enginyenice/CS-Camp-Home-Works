using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService : IBaseService<Rental>
    {
        DataResult<bool> IsDelivery(int carId);

        DataResult<List<RentalDetailDto>> GetAllRentalDetails();
    }
}
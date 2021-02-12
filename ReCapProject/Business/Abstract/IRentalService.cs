using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService : IBaseService<Rental>
    {
        DataResult<bool> IsDelivery(int carId);
    }
}
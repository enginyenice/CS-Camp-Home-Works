using Core.Business;
using Core.DataAccess;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : BaseManager<Car>
    {
        public CarManager(IBaseRepository<Car> baseService) : base(baseService)
        {
        }
    }
}
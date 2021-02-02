using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : InMemoryBaseDal<Car>
    {
        public override void Update(Car entity)
        {
            Car UpdateToCar = _entities.SingleOrDefault(c => c.Id == entity.Id);
            UpdateToCar.BrandId = entity.BrandId;
            UpdateToCar.ColorId = entity.ColorId;
            UpdateToCar.DailyPrice = entity.DailyPrice;
            UpdateToCar.ModelYear = entity.ModelYear;
        }
    }
}
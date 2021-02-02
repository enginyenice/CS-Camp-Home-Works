using DataAccess;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : BaseManager<Brand>
    {
        public BrandManager(IBaseRepository<Brand> baseService) : base(baseService)
        {
        }
    }
}
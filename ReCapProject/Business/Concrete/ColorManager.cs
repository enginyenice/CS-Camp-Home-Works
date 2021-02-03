using Core.Business;
using Core.DataAccess;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : BaseManager<Color>
    {
        public ColorManager(IBaseRepository<Color> baseService) : base(baseService)
        {
        }
    }
}
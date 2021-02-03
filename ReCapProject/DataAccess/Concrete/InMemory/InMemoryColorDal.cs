using Core.DataAccess.InMemory;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : InMemoryBaseDal<Color>
    {
        public override void Update(Color entity)
        {
            Color UpdateOfColor = _entities.SingleOrDefault(p => p.Id == entity.Id);
            UpdateOfColor.Name = entity.Name;
        }
    }
}
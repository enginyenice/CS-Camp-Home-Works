using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        private readonly List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color {Id=1,Name="Siyah"},
                new Color {Id=2,Name="Beyaz"},
                new Color {Id=3,Name="Kırmızı"},
                new Color {Id=4,Name="Mavi"},
                new Color {Id=5,Name="Gri"}
            };
        }

        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color DeleteOfColor = _colors.SingleOrDefault(p => p.Id == entity.Id);
            _colors.Remove(DeleteOfColor);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public Color GetById(int id)
        {
            return _colors.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Color entity)
        {
            Color UpdateOfColor = _colors.SingleOrDefault(p => p.Id == entity.Id);
            UpdateOfColor.Name = entity.Name;
        }
    }
}
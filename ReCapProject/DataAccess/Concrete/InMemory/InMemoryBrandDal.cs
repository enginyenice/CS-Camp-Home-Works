using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        private readonly List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>() {
            new Brand{ Id = 1, Name="Peugeot 301"},
            new Brand{ Id = 2, Name="Renault Broadway 1.4 GTE"},
            new Brand{ Id = 3, Name="Opel 1.3 CDTI Sport"},
            new Brand{ Id = 4, Name="1.3 CDTI Sport  E-180 Edition-E"},
            new Brand{ Id = 5, Name="Volkswagen Passat1.4 TSI BlueMotion"},
            new Brand{ Id = 6, Name="Fiat Egea 1.3 Multijet Easy"},
            };
        }

        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(Brand entity)
        {
            Brand DeleteOfBrand = _brands.SingleOrDefault(p => p.Id == entity.Id);
            _brands.Remove(entity);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Brand entity)
        {
            Brand UpdateOfBrand = _brands.SingleOrDefault(p => p.Id == entity.Id);
            UpdateOfBrand.Name = entity.Name;
        }
    }
}
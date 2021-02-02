using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brand;

        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }

        public void Add(Brand entity)
        {
            _brand.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brand.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _brand.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brand.GetById(id);
        }

        public void Update(Brand entity)
        {
            _brand.Update(entity);
        }
    }
}
using Business.Abstract;
using DataAccess;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseService;

        public BaseManager(IBaseRepository<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public void Add(TEntity entity)
        {
            _baseService.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _baseService.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _baseService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _baseService.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _baseService.Update(entity);
        }
    }
}
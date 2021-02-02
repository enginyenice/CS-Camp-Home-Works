using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public abstract class InMemoryBaseDal<TEntity> : IBaseRepository<TEntity> where TEntity: BaseEntity
    {
        public readonly List<TEntity> _entities;

        public InMemoryBaseDal()
        {
            _entities = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            TEntity DeleteToEntity = _entities.First(p => p.Id == p.Id);
            _entities.Remove(DeleteToEntity);
        }

        public List<TEntity> GetAll()
        {
            return _entities;
        }

        public TEntity GetById(int id)
        {
            return _entities.SingleOrDefault(p => p.Id == id);
        }

        public abstract void Update(TEntity entity);
        
    }
}

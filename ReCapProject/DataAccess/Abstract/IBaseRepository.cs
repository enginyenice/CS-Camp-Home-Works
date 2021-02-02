using Entities.Abstract;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
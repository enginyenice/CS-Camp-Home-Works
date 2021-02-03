using Entities.Concrete;
using System.Collections.Generic;

namespace Core.DataAccess
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
using Entities.Abstract;
using System.Collections.Generic;

namespace Core.Business
{
    public interface IBaseService<TEntity> where TEntity : IEntity
    {
        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
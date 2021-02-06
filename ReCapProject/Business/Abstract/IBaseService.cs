using Core.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBaseService<T> where T : IEntity
    {
        List<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
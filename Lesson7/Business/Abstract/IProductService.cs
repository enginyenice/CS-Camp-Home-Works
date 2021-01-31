using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
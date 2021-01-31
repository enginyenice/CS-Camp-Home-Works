using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : IProductDal
    {
        private List<Product> _products;

        public EFProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToEdit = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToEdit.CategoryId = product.CategoryId;
            productToEdit.ProductName = product.ProductName;
            productToEdit.UnitsInStock = product.UnitsInStock;
            productToEdit.UnitPrice = product.UnitPrice;
        }
    }
}
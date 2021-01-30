using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("In Memory Product Dal");
            ProductManager InMemoryProductManager = new ProductManager(new InMemoryProductDal());
            InMemoryProductManager.Add(new Product { CategoryId = 3, ProductId = 10, ProductName = "Çerçeve", UnitPrice = 25, UnitsInStock = 2 });
            foreach (var product in InMemoryProductManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Entity Framework Product Dal");
            ProductManager EntityProductManager = new ProductManager(new EFProductDal());
            EntityProductManager.Add(new Product { CategoryId = 5, ProductId = 15, ProductName = "Sandalye", UnitPrice = 75, UnitsInStock = 2 });
            foreach (var product in EntityProductManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
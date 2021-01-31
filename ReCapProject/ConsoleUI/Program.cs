using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 35, ModelYear = 2000, Description = "Lokal boya mevcut" };
            Car car2 = new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 35, ModelYear = 2000, Description = "10.000TL hasar kaydı var." };
            carManager.Add(car1);
            carManager.Add(car2);
            car2.Description = "12.500TL hasar kaydı var.";
            carManager.Update(car2);
            carManager.Delete(car1);

            Console.WriteLine("---Get All---");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0} BrandId: {1} ColorId: {2} DailyPrice: {3} ModelYear: {4} Description: {5}", car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
            }
            Console.WriteLine("---Get By Id---");
            Car car3 = carManager.GetById(2);
            Console.WriteLine("Id: {0} BrandId: {1} ColorId: {2} DailyPrice: {3} ModelYear: {4} Description: {5}", car3.Id, car3.BrandId, car3.ColorId, car3.DailyPrice, car3.ModelYear, car3.Description);
        }
    }
}
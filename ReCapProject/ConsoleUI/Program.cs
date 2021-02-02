using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());

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
                Console.WriteLine("Id:          {0}\n" +
                                  "Marka:       {1}\n" +
                                  "Renk:        {2}\n" +
                                  "Günlük Fiyat:{3}\n" +
                                  "Model Yılı:  {4}\n" +
                                  "Açıklama:    {5}", car.Id, brandManager.GetById(car.BrandId).Name, colorManager.GetById(car.ColorId).Name, car.DailyPrice, car.ModelYear, car.Description);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
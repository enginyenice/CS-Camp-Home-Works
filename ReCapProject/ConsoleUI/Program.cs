using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static CarManager carManager;
        private static BrandManager brandManager;
        private static ColorManager colorManager;

        private static void Main()
        {
            carManager = new CarManager(new InMemoryCarDal());
            brandManager = new BrandManager(new InMemoryBrandDal());
            colorManager = new ColorManager(new InMemoryColorDal());
            AddData();
            GetAll();
        }

        private static void AddData()
        {
            // Add Car
            Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 35, ModelYear = 2000, Description = "Lokal boya mevcut" };
            Car car2 = new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 35, ModelYear = 2000, Description = "10.000 TL hasar kaydı var." };
            Car car3 = new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 35, ModelYear = 2000, Description = "5.000TL hasar kaydı var." };
            Car car4 = new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 35, ModelYear = 2000, Description = "2.000TL hasar kaydı var." };
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
            car2.Description = "12.500TL hasar kaydı var.";
            carManager.Update(car2);

            // Add Brand
            Brand brand1 = new Brand { Id = 1, Name = "Fiat Egea 1.3 Multijet Easy" };
            Brand brand2 = new Brand { Id = 2, Name = "Renault Clio 1.2 Icon" };
            Brand brand3 = new Brand { Id = 3, Name = "Ford	Focus 1.6 Titanium" };
            Brand brand4 = new Brand { Id = 4, Name = "Hyundai	i20	1.4 MPI Style" };
            brandManager.Add(brand1);
            brandManager.Add(brand2);
            brandManager.Add(brand3);
            brandManager.Add(brand4);

            // Add Color
            Color color1 = new Color { Id = 1, Name = "Siyah" };
            Color color2 = new Color { Id = 2, Name = "Beyaz" };
            Color color3 = new Color { Id = 3, Name = "Gri" };
            Color color4 = new Color { Id = 4, Name = "Mavi" };

            colorManager.Add(color1);
            colorManager.Add(color2);
            colorManager.Add(color3);
            colorManager.Add(color4);
        }

        private static void GetAll()
        {
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
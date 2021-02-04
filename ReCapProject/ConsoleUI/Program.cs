using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal static class Program
    {
        private static CarManager carManager;
        private static BrandManager brandManager;
        private static ColorManager colorManager;
        private static void Main()
        {
            carManager = new CarManager(new EfCarDal());
            brandManager = new BrandManager(new EfBrandDal());
            colorManager = new ColorManager(new EfColorDal());
            /*
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 45, ModelYear = 1998, Description = "Harika Araç" });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 45, ModelYear = 1997, Description = "Harika Araç" });
            carManager.Add(new Car { BrandId = 3, ColorId = 3, DailyPrice = 65, ModelYear = 2007, Description = "Harika Araç" });
            carManager.Add(new Car { BrandId = 4, ColorId = 4, DailyPrice = 75, ModelYear = 2017, Description = "Harika Araç" });
            carManager.Add(new Car { BrandId = 5, ColorId = 5, DailyPrice = 85, ModelYear = 2021, Description = "Harika Araç" });

            brandManager.Add(new Brand { Name = "Peugeot" });
            brandManager.Add(new Brand { Name = "Renault" });
            brandManager.Add(new Brand { Name = "Opel" });
            brandManager.Add(new Brand { Name = "Toyota" });
            brandManager.Add(new Brand { Name = "BMW" });

            colorManager.Add(new Color { Name = "Siyah" });
            colorManager.Add(new Color { Name = "Beyaz" });
            colorManager.Add(new Color { Name = "Gri" });
            colorManager.Add(new Color { Name = "Mavi" });
            colorManager.Add(new Color { Name = "Kırmızı" });
           

            carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 45, ModelYear = 1999, Description = "Lorem ipsum dolor sit amet." });
            carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 45, ModelYear = 2013, Description = "Lorem ipsum dolor sit amet." });
            carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 65, ModelYear = 2004, Description = "Lorem ipsum dolor sit amet." });
            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 75, ModelYear = 1997, Description = "Lorem ipsum dolor sit amet." });
            carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 85, ModelYear = 2010, Description = "Lorem ipsum dolor sit amet." });
             */
            Console.WriteLine("Get All");
            CarDataWriteLine(carManager.GetAll());
            Console.WriteLine("GetCarsByBrandId => 4");
            CarDataWriteLine(carManager.GetCarsByBrandId(4));

            Console.WriteLine("GetCarsByBrandId => 5");
            CarDataWriteLine(carManager.GetCarsByBrandId(5));

            Console.WriteLine("Araba Ekleme İşlemi");
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 1, ModelYear = 1998, Description = "M" });
        }
        private static void CarDataWriteLine(List<Car> cars)
        {
            Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
            foreach (var car in cars)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", car.Id, brandManager.Get(car.BrandId).Name,colorManager.Get(car.ColorId).Name,car.ModelYear,car.DailyPrice, car.Description);
            }
            Console.WriteLine();
        }
    }
}
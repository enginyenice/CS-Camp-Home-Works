using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal static class Program
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
            Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 35, ModelYear = 2000, Description = "Well maintained vehicle" };
            Car car2 = new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 45, ModelYear = 2001, Description = "Well maintained vehicle" };
            Car car3 = new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 55, ModelYear = 2002, Description = "Well maintained vehicle" };
            Car car4 = new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 65, ModelYear = 2003, Description = "Well maintained vehicle" };
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
            
            // Add Brand
            Brand brand1 = new Brand { Id = 1, Name = "Fiat Egea 1.3 Multijet Easy" };
            Brand brand2 = new Brand { Id = 2, Name = "Renault Clio 1.2 Icon" };
            Brand brand3 = new Brand { Id = 3, Name = "Ford Focus 1.6 Titanium" };
            Brand brand4 = new Brand { Id = 4, Name = "Hyundai i20 1.4 MPI Style" };
            brandManager.Add(brand1);
            brandManager.Add(brand2);
            brandManager.Add(brand3);
            brandManager.Add(brand4);

            // Add Color
            Color color1 = new Color { Id = 1, Name = "Black" };
            Color color2 = new Color { Id = 2, Name = "White" };
            Color color3 = new Color { Id = 3, Name = "Grey" };
            Color color4 = new Color { Id = 4, Name = "Blue" };

            colorManager.Add(color1);
            colorManager.Add(color2);
            colorManager.Add(color3);
            colorManager.Add(color4);
        }

        private static void GetAll()
        {
            Console.WriteLine("|{0,2}|" +
                              "{1,30}|" +
                              "{2,6}|" +
                              "{3,12}|" +
                              "{4,12}|" +
                              "{5,30}|", "ID", "BRAND", "COLOR", "DAILY PRICE", "MODEL YEAR", "DESCRIPTION");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("|{0,2}|" +
                                  "{1,30}|" +
                                  "{2,6}|" +
                                  "{3,12}|" +
                                  "{4,12}|" +
                                  "{5,30}|", car.Id, brandManager.GetById(car.BrandId).Name, colorManager.GetById(car.ColorId).Name, car.DailyPrice, car.ModelYear, car.Description);
            }
        }
    }
}
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
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
            */

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}{1}", "Id           :", car.Id);
                Console.WriteLine("{0}{1}", "Marka        :", brandManager.Get(car.BrandId).Name);
                Console.WriteLine("{0}{1}", "Renk         :", colorManager.Get(car.ColorId).Name);
                Console.WriteLine("{0}{1}", "Model Yılı   :", car.ModelYear);
                Console.WriteLine("{0}{1}", "Günlük Fiyat :", car.DailyPrice);
                Console.WriteLine("{0}{1}", "Açıklama     :", car.Description);
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("Araba Ekleme İşlemi");
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 1, ModelYear = 1998, Description = "M" });
        }
    }
}
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal static class Program
    {
        private static CarManager carManager;

        private static void Main()
        {
            //AddItem(); //Veritabanını doldurmak için
            //Homework_03_02_2021(); // 03 02 2021 Ödevi
            Lesson_06_02_2021(); // 06 02 2021 Ders Özeti
        }

        private static void AddItem()
        {
            carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            colorManager.Add(new Color { ColorName = "Siyah" });
            colorManager.Add(new Color { ColorName = "Beyaz" });
            colorManager.Add(new Color { ColorName = "Mavi" });
            colorManager.Add(new Color { ColorName = "Gri" });
            colorManager.Add(new Color { ColorName = "Kırmızı" });

            brandManager.Add(new Brand { BrandName = "BMW" });
            brandManager.Add(new Brand { BrandName = "Mercedes" });
            brandManager.Add(new Brand { BrandName = "Peugeot" });
            brandManager.Add(new Brand { BrandName = "Volkswagen" });
            brandManager.Add(new Brand { BrandName = "Renault" });

            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = 2001, Description = "Sadece şirketlere kiralık" });
            carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 230, ModelYear = 2005, Description = "Sadece bireysel kiralık" });
            carManager.Add(new Car { BrandId = 3, ColorId = 5, DailyPrice = 300, ModelYear = 2010, Description = "En fazla 5 gün kiralanabilir" });
            carManager.Add(new Car { BrandId = 4, ColorId = 2, DailyPrice = 150, ModelYear = 1990, Description = "Nostalji" });
            carManager.Add(new Car { BrandId = 5, ColorId = 3, DailyPrice = 900, ModelYear = 2018, Description = "Şehir dışına kiralık değildir." });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 1985, Description = "Sağlam getir yeter" });
        }

        private static void Lesson_06_02_2021()
        {
            carManager = new CarManager(new EfCarDal());
            Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
            foreach (var car in carManager.GetCarsDetail())
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", car.CarId, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();
        }

        private static void Homework_03_02_2021()
        {
            carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Get All");
            var cars = carManager.GetAll();

            /*
            Console.WriteLine("GetCarsByBrandId => 4");
            var cars = carManager.GetCarsByBrandId(4));
            */

            /*
            Console.WriteLine("GetCarsByBrandId => 5");
            var cars = carManager.GetCarsByBrandId(5));
            */

            /*
            Console.WriteLine("Araba Ekleme İşlemi");
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 1, ModelYear = 1998, Description = "M" });
            */

            Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
            foreach (var car in cars)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();
        }
    }
}
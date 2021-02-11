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

            
            //Color Add 
            Console.WriteLine(colorManager.Add(new Color { ColorName = "Mor" }).Message);
            Console.WriteLine(colorManager.Add(new Color { ColorName = "Pembe" }).Message);
            Console.WriteLine(colorManager.Add(new Color { ColorName = "Lacivert" }).Message);
            Console.WriteLine(colorManager.Add(new Color { ColorName = "Yeşil" }).Message);
            Console.WriteLine(colorManager.Add(new Color { ColorName = "Eflatun" }).Message);

            //Brand Add
            Console.WriteLine(brandManager.Add(new Brand { BrandName = "Ferrari" }).Message);
            Console.WriteLine(brandManager.Add(new Brand { BrandName = "Porshce" }).Message);
            Console.WriteLine(brandManager.Add(new Brand { BrandName = "Tesla" }).Message);
            Console.WriteLine(brandManager.Add(new Brand { BrandName = "Suziki" }).Message);
            Console.WriteLine(brandManager.Add(new Brand { BrandName = "Toyota" }).Message);

            //Car Add
            Console.WriteLine(carManager.Add(new Car { BrandId = 7, ColorId = 2, DailyPrice = 1200, ModelYear = 2001, Description = "Sadece şirketlere kiralık" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = 6, ColorId = 3, DailyPrice = 3000, ModelYear = 2010, Description = "En fazla 5 gün kiralanabilir" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = 5, ColorId = 4, DailyPrice = 1050, ModelYear = 1990, Description = "Nostalji" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = 4, ColorId = 5, DailyPrice = 9000, ModelYear = 2018, Description = "Şehir dışına kiralık değildir." }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = 3, ColorId = 6, DailyPrice = 1800, ModelYear = 1985, Description = "Sağlam getir yeter" }).Message);
        }

        private static void Lesson_06_02_2021()
        {
            carManager = new CarManager(new EfCarDal());
            
            var carsDetails = carManager.GetCarsDetail();
            if(carsDetails.Success)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
                foreach (var car in carsDetails.Data)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", car.CarId, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();
            } else
            {
                Console.WriteLine(carsDetails.Message);
            }
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

            if(cars.Success)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
                foreach (var car in cars.Data)
                {
                    Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }
                Console.WriteLine();
            } else
            {
                Console.WriteLine(cars.Message);
            }
        }
    }
}
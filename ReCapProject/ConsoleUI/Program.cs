using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal static class Program
    {
        private static CarManager carManager;
        private static CustomerManager customerManager;
        private static UserManager userManager;
        private static RentalManager rentalManager;

        private static void Main()
        {
            //AddItem(); //Veritabanını doldurmak için
            //Homework_03_02_2021(); // 03 02 2021 Ödevi
            //Lesson_06_02_2021(); // 06 02 2021 Ders Özeti

            //10 02 2021 Ders Ödevi
            //CreateCustomer(); // Müşteri oluşturur.
            RentalCarAdd();
        }

        private static void RentalCarAdd()
        {
            rentalManager = new RentalManager(new EfRentalDal());
            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rentalManager.Add(new Rental { CarId = rastgele.Next(1, 6), CustomerId = 1, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 03, 12) }).Message);
            }
        }

        private static void CreateCustomer()
        {
            userManager = new UserManager(new EfUserDal());
            customerManager = new CustomerManager(new EfCustomerDal());

            User user1 = new User { FirstName = "Engin", LastName = "Yenice", Email = "enginyenice2626@gmail.com", Password = "123456" };
            Customer customer1 = new Customer { CompanyName = "Yeni Firma" };
            var createUser = userManager.Add(user1);
            var createdUser = userManager.GetByEmail(user1.Email);
            if (createUser.Success && createdUser.Success)
            {
                customer1.UserId = createdUser.Data.Id;
                customerManager.Add(customer1);
            }
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

            Random rastgele = new Random();

            //Car Add
            Console.WriteLine(carManager.Add(new Car { BrandId = rastgele.Next(1, 6), ColorId = rastgele.Next(1, 6), DailyPrice = rastgele.Next(1000, 10001), ModelYear = rastgele.Next(1990, 2022), Description = "Sadece şirketlere kiralık" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = rastgele.Next(1, 6), ColorId = rastgele.Next(1, 6), DailyPrice = rastgele.Next(1000, 10001), ModelYear = rastgele.Next(1990, 2022), Description = "En fazla 5 gün kiralanabilir" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = rastgele.Next(1, 6), ColorId = rastgele.Next(1, 6), DailyPrice = rastgele.Next(1000, 10001), ModelYear = rastgele.Next(1990, 2022), Description = "Nostalji" }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = rastgele.Next(1, 6), ColorId = rastgele.Next(1, 6), DailyPrice = rastgele.Next(1000, 10001), ModelYear = rastgele.Next(1990, 2022), Description = "Şehir dışına kiralık değildir." }).Message);
            Console.WriteLine(carManager.Add(new Car { BrandId = rastgele.Next(1, 6), ColorId = rastgele.Next(1, 6), DailyPrice = rastgele.Next(1000, 10001), ModelYear = rastgele.Next(1990, 2022), Description = "Sağlam getir yeter" }).Message);
        }

        private static void Lesson_06_02_2021()
        {
            carManager = new CarManager(new EfCarDal());

            var carsDetails = carManager.GetCarsDetail();
            if (carsDetails.Success)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
                foreach (var car in carsDetails.Data)
                {
                    Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,30}|", car.CarId, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(carsDetails.Message);
            }
        }

        private static void Homework_03_02_2021()
        {
            carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Get All");
            var cars = carManager.GetAll();
            if (cars.Success)
            {
                Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", "ID", "Marka", "Renk", "Model", "Fiyat", "Açıklama");
                foreach (var car in cars.Data)
                {
                    Console.WriteLine("|{0,4}|{1,10}|{2,10}|{3,6}|{4,8}|{5,50}|", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(cars.Message);
            }
        }
    }
}
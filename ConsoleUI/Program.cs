using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }

            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 3, TransmissionId = 1, Description = "Yeni Araba", DailyPrice = 190, ModelYear = "2005" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }

            carManager.Update(new Car { CarId = 6, BrandId = 2, ColorId = 3, TransmissionId = 1, Description = "Ford Fiesta", DailyPrice = 190, ModelYear = "2005" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }

            carManager.Delete(new Car { CarId = 6, BrandId = 2, ColorId = 3, TransmissionId = 1, Description = "Ford Fiesta", DailyPrice = 190, ModelYear = "2005" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }

            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 3, TransmissionId = 1, Description = "Yeni", DailyPrice = 0, ModelYear = "2005" });
            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 3, TransmissionId = 1, Description = "Ye", DailyPrice = 10, ModelYear = "2005" });


            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine(car.CarId + " " + car.Description);
            }




        }
    }
}

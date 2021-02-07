using Business.Concrete;
using Console;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tümünü Listeleme
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear);

            }

            //Tekli Listeleme
            System.Console.WriteLine("\n");

            foreach (var car in carManager.GetById(1))
            {
                System.Console.WriteLine(car.ModelYear);

            }

            //Ekleme
            Car car1 = new Car() { Id = 6, BrandId = 2, ColorId = 1, DailyPrice = 170, Description = "Kiralık Yeni Araç", ModelYear = 2019 };
            carManager.Add(car1);

            System.Console.WriteLine("\n");

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear);

            }
            //Güncelleme
            Car car2 = new Car() { Id = 6, BrandId = 2, ColorId = 1, DailyPrice = 170, Description = "Kiralık Yeni Araç", ModelYear = 2017 };
            carManager.Update(car2);

            System.Console.WriteLine("\n");

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear);

            }

            //Silme
            carManager.Delete(car2);

            System.Console.WriteLine("\n");
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear);

            }
        }


    }
}
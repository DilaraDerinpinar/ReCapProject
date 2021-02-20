using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("************GET ALL LIST*********");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} \n Model: {item.Description} \n Model Year: {item.ModelYear} \n Color id: {item.ColorId} \n Daily Price: {item.DailyPrice} \n Brand ID: {item.BrandId}");
            }

            Console.WriteLine("***************");

            Console.WriteLine("--GetById=2");
            foreach (var item in carManager.GetById(2))
            {
                Console.WriteLine($"Car id: {item.Id} \nCar model: {item.Description}");
            }

            Console.ReadLine();


        }
    }
}

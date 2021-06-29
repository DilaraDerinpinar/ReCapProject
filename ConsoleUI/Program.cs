using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************INMEMORYDAL ILE CALISILAN KISIM:****************

            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //Console.WriteLine("************GET ALL LIST*********");
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine($"Id: {item.Id} \n Model: {item.Description} \n Model Year: {item.ModelYear} \n Color id: {item.ColorId} \n Daily Price: {item.DailyPrice} \n Brand ID: {item.BrandId}");
            //}

            //Console.WriteLine("***************");

            //Console.WriteLine("--GetById=2");
            //foreach (var item in carManager.GetById(2))
            //{
            //    Console.WriteLine($"Car id: {item.Id} \nCar model: {item.Description}");
            //}

            //**************************************************

            //EntityFrameworkAddTest();
            //EntityFrameworkDeleteTest();
            //EntityFrameworkUpdateTest();

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetProductDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            Console.ReadLine();


        }

        /*
        private static void EntityFrameworkAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }
            carManager.Add(new Car { BrandId = 5, ColorId = 3, DailyPrice = 350, Description = "Otomatik", ModelYear = 2021 });
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }
        }

        private static void EntityFrameworkDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }
            carManager.Delete(new Car { Id = 3 });
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }
        }





        public static void EntityFrameworkUpdateTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }
            carManager.Update(new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2016, Description = "Manuel", DailyPrice = 200 });
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Id + " " + c.Description + " Daily Price is: " + c.DailyPrice + "$");
            }


        }
        */
    }
}

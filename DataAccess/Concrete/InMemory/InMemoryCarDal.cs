using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
/*
namespace DataAccess.Concrete.InMemory
{

   public class InMemoryCarDal:ICarDal
   {

       List<Car> _cars;
       public InMemoryCarDal()
       {
           _cars = new List<Car>
           {
               new Car{BrandId = 1,ColorId = 1,DailyPrice = 200,Description = "Nissan Juke",Id=1,ModelYear = 2020},
               new Car{BrandId = 2,ColorId = 1,DailyPrice = 100,Description = "Renault Captur",Id=2,ModelYear = 2017},
               new Car{BrandId = 2,ColorId = 3,DailyPrice = 250,Description = "Nissan X-TRAIL",Id=3,ModelYear = 2021},
               new Car{BrandId = 3,ColorId = 4,DailyPrice = 150,Description = "Ford Fiesta",Id=4,ModelYear = 2016},
               new Car{BrandId = 4,ColorId = 1,DailyPrice = 120,Description = "Toyota Yaris",Id=5,ModelYear = 2017}
           };
       }

       public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
       {
           throw new NotImplementedException();
       }

       public Car Get(Expression<Func<Car, bool>> filter)
       {
           throw new NotImplementedException();
       }

       public  void Add(Car car)
       {
           _cars.Add(car);
       }

       public  void Update(Car car)
       {

           Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

           carToUpdate.ColorId = car.ColorId;
           carToUpdate.ModelYear = car.ModelYear;
           carToUpdate.DailyPrice = car.DailyPrice;
           carToUpdate.Description = car.Description;
           carToUpdate.BrandId = car.BrandId;


       }

       public  void Delete(Car car)
       {
           Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
           _cars.Remove(carToDelete);
       }






       public  List<Car> GetById(int id)
       {
           return _cars.Where(c => c.Id == id).ToList();
       }

       public List<CarDetailDto> GetProductDetails()
       {
           throw new NotImplementedException();
       }


   }

}
*/

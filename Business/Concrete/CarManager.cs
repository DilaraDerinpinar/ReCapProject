using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("The car was deleted!");
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("The cars info was updated!");
            }
            else
            {
                Console.WriteLine("Please enter correct car daily price!");
            }
        }

      

       

       
        

        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Message.CarAdded);
            }
            else
            {
                return new ErrorResult(Message.CarIsNot);
            }
        }

        public IDataResult<List<CarDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetProductDetails());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Message.AllListCar);
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }
    }
}

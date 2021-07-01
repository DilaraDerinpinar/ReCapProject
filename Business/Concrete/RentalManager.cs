using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
       
        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Message.RentalError);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Message.RentalAdded);


        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            Console.WriteLine("The rental info was deleted!");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Message.AllRental);
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
            Console.WriteLine("The rental info was updated!");
        }
    }
}

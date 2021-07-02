﻿using Business.Abstract;
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

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Message.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Message.AllRental);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            
             return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
            
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Message.RentalUpdated);
        }
    }
}

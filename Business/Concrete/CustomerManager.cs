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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Message.CustomerAdded);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            Console.WriteLine("The customer was deleted!!");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Message.AllCustomer);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
            Console.WriteLine("The customers info was updated!!");
        }
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
    }
}

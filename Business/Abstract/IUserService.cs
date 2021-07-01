using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        void Delete(User user);
        void Update(User user);
        IDataResult<List<User>> GetAll();



    }
}

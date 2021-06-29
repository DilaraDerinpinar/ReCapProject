using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalCarContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (RentalCarContext rentalCarContext = new RentalCarContext())
            {
                var result = from c in rentalCarContext.Cars
                             join b in rentalCarContext.Brands
                                 on c.BrandId equals b.BrandID
                             join cr in rentalCarContext.Colors
                             on c.ColorId equals cr.ColorID

                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cr.ColorName,
                                 DailyPrice=(int)c.DailyPrice


                             };
                return result.ToList();
            }
        }
    }
}

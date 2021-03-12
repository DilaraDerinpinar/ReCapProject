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
        public List<ProductDetailDto> GetProductDetails()
        {
            using (RentalCarContext rentalCarContext = new RentalCarContext())
            {
                var result = from c in rentalCarContext.Cars
                             join b in rentalCarContext.Brands
                                 on c.BrandId equals b.BrandID
                             join cr in rentalCarContext.Colors
                             on c.ColorId equals cr.ColorID

                             select new ProductDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cr.ColorName,
                                 DailyPrice=c.DailyPrice


                             };
                return result.ToList();
            }
        }
    }
}

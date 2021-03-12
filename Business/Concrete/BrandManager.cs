using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        //public void Add(Brand brand)
        //{
        //    if (brand.BrandName.Length > 2)
        //    {
        //        _brandDal.Add(brand);
        //        Console.WriteLine("Brand was added!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect Brand name");
        //    }

        //}

        //public void Delete(Brand brand)
        //{

        //    Console.WriteLine("{0} was deleted!", brand.BrandName);
        //    _brandDal.Delete(brand);
        //}

        //public void Update(Brand brand)
        //{
        //    _brandDal.Update(brand);
        //    Console.WriteLine("{0} was updated!", brand.BrandName);
        //}

        //public List<Brand> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Brand> GetCarsByBrandId(int brandId)
        //{
        //    return _brandDal.GetAll();
        //}

        Brand IBrandService.GetCarsByBrandId(int brandId)
        {
            return _brandDal.Get(b => b.BrandID == brandId);
        }
    }
}

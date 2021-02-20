using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities.Dtos;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using DateAccess.Abstract;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentDbContext context = new CarRentDbContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = br.Id,
                                 BrandName = br.Name,
                                
                                 ColorId = co.Id,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
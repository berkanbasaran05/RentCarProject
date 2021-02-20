using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentDbContext>, IColorDal
    {

    }
}
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DateAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentDbContext>, IBrandDal
    {
    }
}
//using DateAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DateAccess.Concrete.InMemory
//{
//    public class InMemoryBrandDal : IBrandDal
//    {

//        List<Brand> _brands;

//        public InMemoryBrandDal()
//        {
//            _brands = new List<Brand>
//            {
//                new Brand{BrandId = 1, Name = "PEUGOET", Model = "206"},
//                new Brand{BrandId = 2, Name = "HYUNDAİ", Model = "i30"},
//                new Brand{BrandId = 3, Name = "AUDI", Model = "A3 SPORTBACK"},
//                new Brand{BrandId = 4, Name = "TOYOTA", Model = "COROLLA"},
//                new Brand{BrandId = 5, Name = "MERCEDES", Model = "E250"},
//            };
//        }
//        public void Add(Brand brand)
//        {
//            _brands.Add(brand);
//        }

//        public void Add(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Add(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Add(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(Brand brand)
//        {
//            var brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
//            _brands.Remove(brandToDelete);
//        }

//        public void Delete(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public Brand Get(Expression<Func<Brand, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public Brand Get(System.Linq.Expressions.Expression<Func<Brand>, bool> 1, filter 2)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Brand> GetAll()
//        {
//            return _brands;
//        }

//        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public Brand GetById(int id)
//        {
//            return _brands.SingleOrDefault(b => b.BrandId == id);
//        }

//        public void Update(Brand brand)
//        {
//            var brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);

//            brandToUpdate.BrandId = brand.BrandId;
//            brandToUpdate.Model = brand.Model;
//            brandToUpdate.Name = brand.Name;
//        }

//        public void Update(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Brand entity)
//        {
//            throw new NotImplementedException();
//        }

//        Brand IEntityRepository<Brand>.Get(System.Linq.Expressions.Expression<Func<Brand>, bool> 1, filter 2)
//        {
//            throw new NotImplementedException();
//        }

//        Brand IEntityRepository<Brand>.Get(System.Linq.Expressions.Expression<Func<Brand>, bool> 1, filter 2)
//        {
//            throw new NotImplementedException();
//        }
//    }

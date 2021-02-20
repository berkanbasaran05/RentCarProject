//using DateAccess.Abstract;
//using Entities.Concrete;
//using Entities.Dtos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DateAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 50, Description = "İkinci El", ModelYear = 2000  },
//            new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 100, Description = "İkinci El", ModelYear = 2005 },
//            new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 200, Description = "İkinci El", ModelYear = 2010 },
//            new Car { CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 250, Description = "İkinci El", ModelYear = 2015 },
//            new Car { CarId = 5, BrandId = 5, ColorId = 5, DailyPrice = 300, Description = "Sıfır Araç", ModelYear = 2020 },
//            };
//            }
        
   

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
//            _cars.Remove(carToDelete);
            
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public void GetById(Car car)
//        {
//            Car carToSelect = _cars.SingleOrDefault(c => c.Id == car.Id);
//            Console.WriteLine("Seçilen araç =" + carToSelect.BrandId);
//        }

//        public List<Car> GetById(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
//            carToUptade.ColorId = car.ColorId;
//            carToUptade.BrandId = car.BrandId;
//            carToUptade.DailyPrice = car.DailyPrice;
//            carToUptade.Description = car.Description;
//            carToUptade.ModelYear = car.ModelYear;


//        }
//    }
//}

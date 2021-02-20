using Business.Concrete;
using DateAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
 class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll() )
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}

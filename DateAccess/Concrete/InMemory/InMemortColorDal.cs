//using DateAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DateAccess.Concrete.InMemory
//{
//    public class InMemortColorDal : IColorDal
//    {
//        List<Color> _colors;
//        public InMemortColorDal()
//        {
//            _colors = new List<Color>
//            {
//                new Color {ColorId = 1,ColorName = "Kırmızı"},
//            new Color { ColorId = 2, ColorName = "Mavi" },
//                new Color {ColorId = 3,ColorName = "Siyah"},
//                new Color {ColorId = 4,ColorName = "Beyaz"},
//                new Color {ColorId = 5,ColorName = "Mavi"},

//            };
//        }
//        public void Add(Color color)
//        {
//            _colors.Add(color);
//        }
//        public void Delete(Color color)
//        {
//            var colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
//            _colors.Remove(colorToDelete);

//        }
//    }
       

    
//}
////Kırmızı   
////Mavi
////Siyah     
////Beyaz     
////Mavi      
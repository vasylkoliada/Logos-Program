using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class3
{
   public   class Prism
   {
       private double size;

       public double GetSize()
       {
           return size;
       }
       public void SetSize(double _size)
       {
           size = _size;
       }

       private double height;

       public double GetHeight()
       {
           return height;
       }

       public void SetHeight(double _height)
       {
           height = _height;
       }

       private int countMargin;

       public int GetMargin()
       {
           return countMargin;
       }

       public void SetMargin(int _countMargin)
       {
           countMargin = _countMargin;
       }

       private double lenght;

       public double GetLenght()
       {
           return lenght;
       }

       public void SetLenght(double _lenght)
       {
           lenght = _lenght;
       }


       private double area;

       public double GetArea()
       {
           return area;
       }

       public void SetArea(double _area)
       {
           area = _area;
       }
      

        public Prism(double _size, double _height , int _countMargin , double _lenght , double _area )
        {
            size = _size;
            height = _height;
            countMargin = _countMargin;
            lenght = _lenght;
            area = _area;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lg7
{
    class LivingPlace
    {

        private int area;
        public string location;
        private int numOFRoom;
        private int price ;

        public int Area
        {
            get { return area; } 
            set { area = value; }
        }

        public int NumOfRoom
        {
            get { return numOFRoom; }
            set { numOFRoom = value; }
        }

        public  float Price
        {
            get { return price; }
            set
            {
                while( value%1000 != 0 )
                {
                    value--;
                }
                price = (int)value;

            }
        }

        public LivingPlace(int _area, int _numOfRoom, string _location, float _price  )
        {
            area= _area;
            numOFRoom = _numOfRoom;
            location = _location;
            Price = _price;
        }

        public void Print()
        {
            Console.WriteLine(area +"  "+ numOFRoom + " "+ location+" " + Price+"");
        }

    }
}

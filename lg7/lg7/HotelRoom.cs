using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lg7
{
    class HotelRoom: LivingPlace
    {
        public int pricePerPlace;
        public int NumOfPlaces;

        private float pricePer;
        public float priceperday
        {
            get { return pricePer; }
            set { pricePer = value; }
        }
        public new float Price
        {
            get { return (float) pricePerPlace/NumOfPlaces; }
        }
       
        public HotelRoom(int _pricePlace, int _numofplace , float _priceperday) : base (34, 5,"dfvsdf", 32)
        {
            pricePerPlace = _pricePlace;
            NumOfPlaces = _numofplace;
            priceperday = _priceperday;
        }

        public new void Print()
        {
            Console.WriteLine(Price + " " + NumOfPlaces + " "+ priceperday);
        }


    }
}

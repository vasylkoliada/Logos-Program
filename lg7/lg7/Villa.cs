using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lg7
{
    class Villa:LivingPlace
    {
        public int numOfBush;
        public bool hasFunt;

        public Villa( int _numOfBush , bool _hasFunt = true): base(345, 3, "cxbfb", 5464)
        {
            numOfBush = _numOfBush;
            hasFunt = _hasFunt;
        }

        public void Print()
        {
            Console.WriteLine(Area +" "+ NumOfRoom +" "+ Price+" "+ location+" "+numOfBush +" "+ hasFunt);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos6
{
    class CustomFloat
    {

        private int zminna;
        private float twozminna;
        public int Zminna { set { zminna = value; } }

        public float Twozminna
        {
            set {
                if (Math.Abs(value) < 1f)
                {
                    twozminna = value;
                }
                else  twozminna = 0f;

            } 
        }
        public CustomFloat() { }
      
        public CustomFloat(float _twozminna , int _zminna )
        {
            twozminna = _twozminna;
            zminna = _zminna;
           
        }
        public CustomFloat(float _twozminna)
        {
            twozminna = _twozminna;
        }

        public void Print()
        {
            Console.WriteLine("New worker: {0} ", zminna + twozminna);
        }
    }
}

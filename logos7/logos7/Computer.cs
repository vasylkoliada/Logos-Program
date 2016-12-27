using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos7
{
   sealed class Computer: Product
   {
        public new int id;
        public string name;
        public string proc;
        public bool touchScreen;

       public Display display;
        public Computer(string _name, string _proc , bool _touchScreen, float _price): base(1245, _price)
        {
            name = _name;
            proc = _proc;
            touchScreen = _touchScreen;
            display = new Display(_name , 0 , 0 , _price*0.25f);
        }

        public override  string ToString()
        {
            return "Name: " + name + "\nproc: " + proc + "\ntouch: " + touchScreen + "\nPrice: " + Price;
        }
    }
}

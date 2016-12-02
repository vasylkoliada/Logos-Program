using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logos5
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp computer = new Comp( "dfd", 100,387,83,true);
            computer.PrintInfo();
            computer.StatusON();
            //Car myCar = new Car("dfv","sdf",3,5,4,true);
            //myCar.color = "red";
            //myCar.isOn = true;
            //myCar.maxSpeed = 200;
            //myCar.currentSpeed = 20;
            //myCar.model = "suzuki";
            //myCar.PrintInto();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logos5
{
    class Car
    {

        public Car(string carColor, string carmodel, int carprice, int carmaxSpeed, int carcurrentSpeed, bool carisOn)
        {
            color = carColor;
            model = carmodel;
            price = carprice;
            maxSpeed = carmaxSpeed;
            currentSpeed = carcurrentSpeed;
            isOn = carisOn;
        }
        public string color;
        public string model;
        public int price;
        public int maxSpeed;
        public int currentSpeed;
        public bool isOn;

        public void PrintInto()
        {
            Console.WriteLine("model;{0}\nColor: {1}\nPrice:{2}\ncurrentSpeed:{3}", color, price,currentSpeed);
        }


    }
}

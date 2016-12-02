using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logos5
{
    class Comp
    {

        public string model;
        public int price;
        public double CP;
        public int OP;
        public bool status;


        public Comp() { }
        public Comp(string _model, int _price, double _ShP, int _OP, bool _status)
        {
            model = _model;
            price =_price;
            CP = _ShP;
            OP = _OP;
            status = _status;
        }


        
        public Comp(string model, int OP, bool status)
        {
            this.model = model;
            this.OP = OP;
            this.status = status;
        }

        public Comp(string model, int _prise) : this("asus", 100, 56.3, 23, true)
        {
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("Модель" + model + "Цiна" +price+ "ЦП"+CP+ "ОП" + OP + "Статус" + status);
        }

        public void StatusON()
        {
            status = true;
        }
        public void StatusOF()
        {
            status = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos7
{
    class Carrot: Product
    {
        public float lenght;

        public Carrot(int _id, float _price  , float _lenght):  base(_id, _price)
        {
            lenght = _lenght;
        }

        public new void PrintGeneralInfo()
        {

            base.PrintGeneralInfo();
            Console.WriteLine("ID:#\nlenght: ${0}", lenght, this.GetType());
        }
    }
}

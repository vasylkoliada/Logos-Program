using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos7
{
   public class Product
    {
        public readonly  int id;
        private float price;

        protected float Price
        {
            get { return price; }
            set { price  = (int) value + 1 - 0.01f; }
        }

        public Product(int _id, float _price = 10.99f)
        {
            id = _id;
            Price = _price;
        }

        public void PrintGeneralInfo()
        {
            
            Console.WriteLine("ID:#{0}\nPrice: ${1}", id, price , this.GetType());
        }
    }
}

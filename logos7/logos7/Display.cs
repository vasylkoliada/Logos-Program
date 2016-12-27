using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos7
{
    class Display: Product
    {
        public string model;
        public int width;
        public int height;


        public string Resolution
        {
            get { return width + "x" + height; }
        }
        public Display(string _model, int _width , int _height, float _price): base(345, _price)
        {
            model = _model;
            width = _width;
            height = _height;
        }


    }
}

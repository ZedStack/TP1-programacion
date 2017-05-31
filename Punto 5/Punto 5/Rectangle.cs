using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5 {
    class Rectangle : Measures {
        public Rectangle (double length) {
            _width = _height = length; // ?
        }
        public Rectangle (double width, double height) {
            _width = width;
            _height = height;
        }

        public override double Area () {
            return _width * _height;
        }

        public override double Volume () {
            return 0;
        }
    }
}

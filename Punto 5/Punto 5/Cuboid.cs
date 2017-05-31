using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5 {
    class Cuboid : Measures {
        public Cuboid (double lenght) {
            _width = _height = _depth = lenght; // ?
        }
        public Cuboid (double width, double height, double depth) {
            _width = width;
            _height = height;
            _depth = depth;
        }

        public override double Area () {
            return 0;
        }
        public override double Volume () {
            return _width * _height * _depth;
        }
    }
}

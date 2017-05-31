using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5 {
    class Sphere : Measures {
        public Sphere (double lenght, bool isDiameter) {
            if (isDiameter)
                _radius = lenght / 2;
            else
                _radius = lenght;
            _diameter = _radius * 2;
        }

        public override double Area () {
            return 0;
        }

        public override double Volume () {
            return (4 / 3) * Math.PI * Math.Pow (_radius, 3);
        }
    }
}

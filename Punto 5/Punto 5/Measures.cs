using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5 {
    abstract class Measures {
        private static int _IDCounter = 0;
        private int _ID;

        protected double _width, _height, _depth, _diameter, _radius;
        
        public Measures () {
            _ID = _IDCounter++;
        }
        
        public abstract double Area ();
        public abstract double Volume ();

        public int ID () {
            return _ID;
        }
    }
}

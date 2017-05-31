using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1 {
    class General {
        protected int [] _attrib;

        public string ToString () {
                string temp = "";

                for (int i = 0; i < _attrib.Length; i++)
                    temp += _attrib [i].ToString ();

                return temp;
        }

        public General (int [] attrib) {
            _attrib = attrib;
        }
    }
}

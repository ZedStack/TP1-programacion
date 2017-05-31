using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3 {
    class DNI {
        private string _dni;
        private bool   _isOk;
        private bool _IsValid () {
            bool value = true;

            try {
                int temp = Convert.ToInt32 (_dni);
            }
            catch (System.FormatException) {
                value = false;
            }
            catch (IndexOutOfRangeException) {
                value = false;
            }

            return value;
        }


        public DNI (string dni) {
            NewDNI (dni);
        }

        public void NewDNI (string dni) {
            _dni = dni;

            if (_IsValid ()) {
                _isOk = true;
            }
            else {
                _isOk = false;
                _dni = null;
            }
        }

        public bool IsOk () {
            return _isOk;
        }
        public string Get () {
            return _dni;
        }
    }
}

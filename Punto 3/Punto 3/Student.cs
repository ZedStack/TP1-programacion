using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3 {
    class Student : Person {
        private DateTime _admissionDate;

        private void _Initialize () {
            Console.Write ("Student full name (firstname): ");
            _name = Console.ReadLine ();

            Console.Write ("DNI: ");
            _dni = new DNI (Console.ReadLine ());

            Console.Write ("Birthdate (dd-mm-yyyy): ");
            _birthdate = Convert.ToDateTime (Console.ReadLine ());

            Console.Write ("Admission date (dd-mm-yyyy): ");
            _admissionDate = Convert.ToDateTime (Console.ReadLine ());

            Console.Write ("Address: ");
            _address = Console.ReadLine ();

            Console.Write ("Phone: ");
            _phone = Convert.ToInt32 (Console.ReadLine ());
        }

        public Student (
            string name,
            string lastName,
            DNI dni,
            DateTime birthdate,
            DateTime admissionDate,
            string address,
            int phone
            ) {
            _name            = name;
            _dni             = dni;
            _birthdate       = birthdate;
            _admissionDate   = admissionDate;
            _address         = address;
            _phone           = phone;
        }
        public Student () {
            _Initialize ();
        }

        public string name () {
            return _name;
        }
        public string DNI () {
            return _dni.Get ();
        }
        public string birthdate () {
            return _birthdate.ToShortDateString ();
        }
        public string admissionDate () {
            return _admissionDate.ToShortDateString ();
        }
        public string address () {
            return _address;
        }
        public int phone () {
            return _phone;
        }
    }
}

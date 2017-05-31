using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3 {
    class Subject {
        private string   _className;
        private string   _description;
        private DateTime _classTimeStart;
        private DateTime _classTimeEnd;
        private string   _professorName;
        private double   _feeValue;
        private int      _studentsAmount;

        public Student [] students;

        private void _Initialize () {
            Console.Write ("Class name: ");
            _className = Console.ReadLine ();

            Console.Write ("Class description: ");
            _description = Console.ReadLine ();

            Console.Write ("Class time starts at (24hs format): ");
            _classTimeStart = Convert.ToDateTime (Console.ReadLine ());

            Console.Write ("Class time ends at (24hs format): ");
            _classTimeEnd = Convert.ToDateTime (Console.ReadLine ());

            Console.Write ("Professor name (firstname): ");
            _professorName = Console.ReadLine ();

            Console.Write ("Fee: $");
            _feeValue = Convert.ToDouble (Console.ReadLine ());

            Console.Write ("How many students: ");
            _studentsAmount = Convert.ToInt32 (Console.ReadLine ());
        }

        public Subject (
            string ClassName,
            string description,
            DateTime classTimeStart,
            DateTime classTimeEnd,
            string professorName,
            double fee,
            int studentsAmount
            ) {
            _className            = ClassName;
            _description          = description;
            _classTimeStart       = classTimeStart;
            _classTimeEnd         = classTimeEnd;
            _professorName        = professorName;
            _feeValue             = fee;
            _studentsAmount       = studentsAmount;

            students = new Student [_studentsAmount];
        }

        public Subject () {
            _Initialize ();

            students = new Student [_studentsAmount];

            for (int i = 0; i < _studentsAmount; i++) {
                NewStudent (i);
            }
        }

        public void NewStudent (int studentNro) {
            students [studentNro] = new Student ();
        }

        public string ClassName () {
            return _className;
        }
        public string Description () {
            return _description;
        }
        public string ClassTimeStart () {
            return _classTimeStart.ToShortTimeString ();
        }
        public string ClassTimeEnd () {
            return _classTimeEnd.ToShortTimeString ();
        }
        public string ProfessorName () {
            return _professorName;
        }
        public double Fee () {
            return _feeValue;
        }
        public int StudentAmount () {
            return _studentsAmount;
        }
    }
}

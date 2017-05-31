using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2 {
    static class Class {
        private static string Reverse (string text) {
            return new string (text.ToCharArray ().Reverse ().ToArray ());
        }

        public static string FuncionA (char data) {
            string temp = "";

            for (char i = 'a'; i <= data; i++)
                temp += i;
            temp = Reverse (temp) + temp;

            return temp;
        }
        public static string FuncionB (char data, int howMany) {
            string temp = "";

            for (char i = 'a'; i <= data; i++) {
                for (int j = 0; j < howMany; j++)
                    temp += i;
            }

            return temp;
        }
        public static string FuncionC (int start, int end) {
            string temp = "";

            for (int i = start; i <= end; i++)
                temp += i.ToString ();

            return temp;
        }
        public static string FuncionD (char data, int howMany) {
            string temp = "";

            for (int i = 0; i < howMany; i++)
                temp += data;

            return temp;
        }
    }
}

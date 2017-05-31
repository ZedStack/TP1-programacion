using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1 {
    class Program {
        static void Main (string [] args) {
            int [] numbers = { 1, 2, 3 };

            Class1 myClass1 = new Class1 (numbers);
            Class2 myClass2 = new Class2 (numbers);
            Class3 myClass3 = new Class3 (numbers);
            Class4 myClass4 = new Class4 (numbers);
            Class5 myClass5 = new Class5 (numbers);

            Console.WriteLine (myClass1.ToString ());
            Console.WriteLine (myClass2.ToString ());
            Console.WriteLine (myClass3.ToString ());
            Console.WriteLine (myClass4.ToString ());
            Console.WriteLine (myClass5.ToString ());

            Console.ReadLine ();
        }
    }
}

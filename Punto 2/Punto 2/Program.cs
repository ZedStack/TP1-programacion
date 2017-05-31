using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2 {
    class Program {
        static void Main (string [] args) {
            Console.WriteLine (Class.FuncionA ('f'));

            Console.WriteLine (Class.FuncionB ('c', 5));

            Console.WriteLine (Class.FuncionC (1, 6));
            Console.WriteLine (Class.FuncionC (7, 12));
            Console.WriteLine (Class.FuncionC (1, 10));
            Console.WriteLine (Class.FuncionC (11, 20));

            Console.WriteLine (Class.FuncionD ('a', 1));
            Console.WriteLine (Class.FuncionD ('a', 2));
            Console.WriteLine (Class.FuncionD ('a', 3));
            Console.WriteLine (Class.FuncionD ('a', 5));
            Console.WriteLine (Class.FuncionD ('a', 8));
            Console.WriteLine (Class.FuncionD ('a', 13));
            Console.WriteLine (Class.FuncionD ('a', 21));

            Console.ReadLine ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5 {
    class Program {
        static void Main (string [] args) {
            Cuboid myCuboid       = new Cuboid (13, 10, 5);
            Rectangle myRectangle = new Rectangle (15);
            Sphere mySphere = new Sphere (30, true);
            Circle myCircle = new Circle (28, false);

            Console.WriteLine (myCuboid.ID ());
            Console.WriteLine (myRectangle.ID ());
            Console.WriteLine (mySphere.ID ());
            Console.WriteLine (myCircle.ID ());

            Console.ReadLine ();
        }
    }
}

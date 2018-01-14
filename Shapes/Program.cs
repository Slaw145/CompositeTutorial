using System;
using System.Collections.Generic;

namespace Graphic
{
    

    

    

    

    class Program
    {
        static void Main(string[] args)
        {
            IShape tri = new Triangle();
            IShape tri1 = new Triangle();
            IShape cir = new Circle();

            Drawing drawing = new Drawing();
            drawing.add(tri1);
            drawing.add(tri1);
            drawing.add(cir);

            drawing.draw("Red");

            drawing.clear();

            drawing.add(tri);
            drawing.add(cir);
            drawing.draw("Green");

            Console.ReadKey();
        }
    }
}

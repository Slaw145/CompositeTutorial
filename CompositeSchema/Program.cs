using System;
using System.Collections.Generic;

namespace Kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf leaf1 = new Leaf();
            Leaf leaf2 = new Leaf();
            Leaf leaf3 = new Leaf();

            Composite composite = new Composite();
            composite.AddChild(leaf1);
            composite.AddChild(leaf2);
            composite.AddChild(leaf3);

            List<IComponent> listchildren = composite.GetChild();

            Console.WriteLine(listchildren.Count);

            leaf1.operation();
            leaf2.operation();

            composite.operation();

            Console.ReadKey();
        }
    }
}

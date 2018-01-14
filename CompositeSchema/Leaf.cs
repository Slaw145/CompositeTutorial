using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt
{
    class Leaf : IComponent
    {
        public void operation()
        {
            Console.WriteLine("display leaf " + this);
        }
    }
}

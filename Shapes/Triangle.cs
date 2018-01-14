using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic
{
    public class Triangle : IShape
    {
        public void draw(string fillColor)
        {
            Console.WriteLine("Drawing Triangle with color " + fillColor);
        }
    }
}

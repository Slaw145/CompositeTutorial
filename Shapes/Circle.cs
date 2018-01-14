using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic
{
    public class Circle : IShape
    {
        public void draw(string fillColor)
        {
            Console.WriteLine("Drawing Circle with color " + fillColor);
        }
    }
}

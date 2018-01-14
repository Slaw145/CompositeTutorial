using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic
{
    public class Drawing : IShape
    {

        private List<IShape> shapes = new List<IShape>();

        public void draw(string fillColor)
        {
            foreach (IShape sh in shapes)
            {
                sh.draw(fillColor);
            }
        }

        public void add(IShape s)
        {
            shapes.Add(s);
        }

        public void remove(IShape s)
        {
            shapes.Remove(s);
        }

        public void clear()
        {
            Console.WriteLine("Clearing all the shapes from drawing");
            shapes.Clear();
        }
    }
}

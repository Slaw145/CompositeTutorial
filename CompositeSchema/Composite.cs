using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();

        public void operation()
        {
            Console.WriteLine("display leaf " + this);
        }

        public void AddChild(IComponent component)
        {
            _children.Add(component);
        }

        public void RemoveChild(IComponent component)
        {
            _children.Remove(component);
        }

        public List<IComponent> GetChild()
        {
            return _children;
        }
    }
}

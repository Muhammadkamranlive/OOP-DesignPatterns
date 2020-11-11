using System;
using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elements = new List<Element>();

        public void Add(Element element)
        {
            this._elements.Add(element);
        }

        public void Remove(Element element)
        {
            this._elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach(var item in this._elements)
            {
                item.Accept(visitor);
            }
        }
    }
}

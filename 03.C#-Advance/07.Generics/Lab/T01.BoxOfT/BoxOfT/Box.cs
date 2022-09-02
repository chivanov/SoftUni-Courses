using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly List<T> elements;

        public int Count
        {
            get
            {
                return this.elements.Count;
            }

        }

        public Box()
        {
            this.elements  = new List<T>();   
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            T result = this.elements[this.elements.Count - 1];

            this.elements.RemoveAt(this.elements.Count - 1);
            return result;
        }
    }

}

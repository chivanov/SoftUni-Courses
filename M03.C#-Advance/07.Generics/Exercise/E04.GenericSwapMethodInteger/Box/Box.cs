using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
    {
        public Box(T element)
        {
            this.Element = element;
        }
        public Box(List<T> listOfElements)
        {
            this.Elements = listOfElements; 
        }
        
        public T Element { get; private set; }

        public List<T> Elements { get; }

        public void Swap(List<T> listOfElements, int indexOne, int indexTwo)
        {
            var firstEl = listOfElements[indexTwo];
            listOfElements[indexTwo] = listOfElements[indexOne];
            listOfElements[indexOne] = firstEl;   
            
        }
        public override string ToString()
        {
           var sb = new StringBuilder();
            foreach (var element in Elements)
            { 
            sb.AppendLine($"{element.GetType()}: {element}");  
            }

            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable<T> where T :IComparable<T>    
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

        public int CompareTo(T other)         
             => Element.CompareTo(other);

        public int CountOfGreaterLement<T>(List<T> list, T readLine) where T : IComparable => list.Count(word => word.CompareTo(readLine) > 0);
        

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
